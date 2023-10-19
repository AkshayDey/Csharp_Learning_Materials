using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class IndexerClssWithMethodOverloading
    {
        public string[] nameString;

        public IndexerClssWithMethodOverloading(int count)
        {
            nameString = new string[count];
        }

        public string this[int index]
        {
            get
            {
                return nameString[index];
            }
            set
            {
                nameString[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach(var allItems in nameString)
                {
                    if(allItems.ToLower() == name.ToLower())
                    {
                        return allItems.ToUpper();
                    }
                }

                return null;
            }
        }

    }
}
