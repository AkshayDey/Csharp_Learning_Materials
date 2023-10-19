using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrincipleExample.Abstraction
{
    public class Membership
    {
        public void GetMemberShipId(IEnroller aEnroller)
        {
            string id = aEnroller.PrepareId();

            aEnroller.ProcessId(id);
           
        }
    }
}
