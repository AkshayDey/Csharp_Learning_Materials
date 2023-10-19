using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class TurboEngine : IEngine
    {

        public double _speed;
        public TurboEngine(double speed)
        {
            _speed = speed;
        }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Start()
        {
            Console.WriteLine("Turbo Engine Starting ");
        }

        public void Stop()
        {
            Console.WriteLine("Turbo Engine Stopping");
        }

        public virtual void IncreaseSpeed(int t)
        {
            Console.WriteLine("Speed has increased in TurboEngine");
        }
    }
}
