using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class IndexerClass
    {
        public string[] names;

        public IndexerClass(int count)
        {
            names = new string[count];
        }

        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
}
