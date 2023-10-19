using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Chart : IPlugin
    {
        private string _name;
        public Chart(string name)
        {
            _name = name;
        }

        public void Start()
        {
            Console.WriteLine($"Running Chart {_name}");
        }
    }
}
