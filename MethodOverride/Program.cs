using System;

namespace MethodOverride
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicle1 = new Vehicle();
            var engine1 = new Engine();

            vehicle1.Model = "Impala";
            vehicle1.Make = "Chevy";
            vehicle1.License = "C0D34L";
            vehicle1.Year = 2018;

            engine1.Cylinders = 4;
            engine1.EnginePower = "197-305";
            engine1.RPM = 6300;

            vehicle1.FirstCar();
            engine1.Engine1();

            Console.WriteLine("Is it a Nice Vehicle?!");
            Console.ReadLine();
             
            
            
        }
    }
}
