using System;
namespace MethodOverride
{
    public class Vehicle
    {
        public string Model;
        public string Make;
        public int Year;
        public string License;

        Engine engine1 = new Engine();
        

        public void FirstCar()
        {
            Console.WriteLine("The Make of this car is {0}....", Make);
            Console.WriteLine("The Model of this car is an {0}...",Model);
            Console.WriteLine("The Year of this car is {0}..",Year);
            Console.WriteLine("The License Plate # is {0}.",License);
            Console.ReadLine();
            

        }

        public void moveForward()
        {
            
        }
        public void moveBackwards()
        {

        }
        public void Stop()
        {

        }
        public void turnRight()
        {

        }
        public void turnLeft()
        {

        }
    }
}
