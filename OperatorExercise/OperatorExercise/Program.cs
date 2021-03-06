using System;

namespace OperatorExercise
{
    
    class operatorTest
    {
        public static double AreaOfCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            return area;
        }
        public static string basicMath(int a, int b)
        {
            int sum = a + b;
            int quotient = a / b;
            int sub = a - b;
            int mult = a * b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}\nThe sum is {sum}.\n {a} x {b} is {mult} and {a} - {b} is {sub}.");
            return "\nArea of Circle";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Enter a large number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a smaller number:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(operatorTest.basicMath(x, y));

                Console.WriteLine("Enter radius of circle:");
                Console.WriteLine($"The area of the circle is {operatorTest.AreaOfCircle(double.Parse(Console.ReadLine()))}");

                Console.WriteLine("Run again? (y/n)");
                string z = Console.ReadLine();
                if (z == "y")
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }
        }
    }
}
