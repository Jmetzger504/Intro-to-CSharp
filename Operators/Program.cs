using System;


namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robotOne = new Robot();
            robotOne.maxSpeed = 10;
            robotOne.type = "Vacuum";

            Robot robotTwo = new Robot();
            robotTwo.maxSpeed = 10;
            robotTwo.type = "Vacuum";

            Console.WriteLine("robotOne == robotTwo evaluates to: " + (robotOne == robotTwo));
            Console.WriteLine("robotOne.Equals(robotTwo) evaluates to: " + robotOne.Equals(robotTwo));
            Console.WriteLine("Now we change robotTwo's maxspeed to 11.");
            robotTwo.maxSpeed++;
            System.Console.WriteLine("robotTwo.maxSpeed is now: " + robotTwo.maxSpeed);
            Console.WriteLine("robotOne.Equals(robotTwo) now evaluates to: " + robotOne.Equals(robotTwo));
        }
    }
}
