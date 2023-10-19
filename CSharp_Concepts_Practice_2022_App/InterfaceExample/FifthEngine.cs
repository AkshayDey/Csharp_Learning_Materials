using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class FifthEngine : TurboEngine
    {
        public FifthEngine(double speed) : base(speed)
        {

        }

        public FifthEngine() : base(0)
        {

        }

        public new  void Start()
        {
            Console.WriteLine("Fifth Engine Starting ");
        }

        public new void Stop()
        {
            Console.WriteLine("Fifth Engine Stopping");
        }

        public override void IncreaseSpeed(int t)
        {
            Console.WriteLine("Speed has increased in FifthEngine");
        }
    }
}
