using FirstDemo.Web.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern
{
    public class TrainingUnitOfWork
    {
        private List<object> _newItems;
        private List<object> _modifiedItems;
        private List<object> _deletedItems;
        private List<object> _clearedItems;
        private SqlTransaction _transaction;
        private SqlConnection _connection;
        private AdoNetUtility _adoNetUtility;
        public TrainingUnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _transaction = _connection.BeginTransaction();
        }
        public void Add(object item)
        {
            _newItems.Add(item);
        }
        public void Update(object item)  
        { 
            _modifiedItems.Add(item);
        }
        public void Delete(object item) 
        { 
            _deletedItems.Remove(item);
        }
        public void Clear(object item) 
        {
            _clearedItems.Add(item);
        }
        public void Commit()
        {
            Execute(_newItems, OperationType.Add);
            Execute(_modifiedItems, OperationType.Update);
            Execute(_deletedItems, OperationType.Delete);
            Execute(_clearedItems, OperationType.Clean);

            try
            {
                _transaction.Commit();
                InitLists();
            }
            catch
            {
                Rollback();
            }
           
        }
        public void Rollback()
        {
            InitLists();
            _transaction.Rollback();
        }
        
        public void InitLists()
        {
            _newItems = new List<object>();
            _modifiedItems = new List<object>();
            _deletedItems = new List<object>();
            _clearedItems = new List<object>();
        }

        private void Execute(List<object>list, OperationType type)
        {
            foreach (var item in list)
            {
                (string sql, List<DbParameter> parameters)result = (null, null);
                    //result = SqlProducer.GetSql(item);

                if(type == OperationType.Add)
                {
                    result = SqlProducer.GetInsertSql(item);
                }
                else if (type == OperationType.Delete)
                {
                    result = SqlProducer.GetDeleteSql(item);
                }
                else if (type == OperationType.Update)
                {
                    result = SqlProducer.GetUpdateSql(item);
                }
                else
                    result = SqlProducer.GetCleanSql(item);

                _adoNetUtility.WriteOperation(result.sql, result.parameters);
            }
        }
    }
}
