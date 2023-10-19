using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger instance;
        private Logger()  // First Techinque to stop the creation
                          // of creating instance of the Logger Class
        {
        }

        public static Logger GetLogger()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}
