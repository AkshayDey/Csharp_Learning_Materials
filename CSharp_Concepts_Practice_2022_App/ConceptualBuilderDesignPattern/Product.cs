using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptualBuilderDesignPattern
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < _parts.Count; i++) //PartOne
            {
                str += _parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Product Parts: " + str + "\n";
        }
    }
}
