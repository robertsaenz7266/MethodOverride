using System;
namespace MethodOverride
{
    public class Engine
    {
        public int Cylinders;
        public string EnginePower;
        public int RPM;

        public virtual void Engine1()
        {
            Console.WriteLine("This car is a {0} cylinder car....", Cylinders);
            Console.WriteLine("This car has {0} HP...", EnginePower);
            Console.WriteLine("This cars RPM reaches {0} @ 197 Horse Power..", RPM);
            Console.ReadLine();
        }

        public class specs:Engine
            {
            public override void Engine1()
            {
                base.Engine1();
            }
        }

        public void Start()
        {
        }
        public void Brake()
        {

        }
        public void Accelerate()
        {

        }
    }
}
