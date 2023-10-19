using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipleExample.Abstraction
{
    public interface IEnroller
    {
        string PrepareId();

        void ProcessId(string id);
    }
}
