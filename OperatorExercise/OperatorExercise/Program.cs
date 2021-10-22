using System;

namespace OperatorExercise
{
    
    class operatorTest
    {
        public static double AreaOfCircle(double r)
        {
            double pi = 3.14;
            double area = pi * (r * r);
            return area;
        }
        public static string basicMath(int a, int b)
        {

            int sum = a + b;
            int quotient = a / b;
            int sub = a - b;
            int mult = a * b;
            int remainder = a % b;

           
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
           
            return "Thank You\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a large number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a smaller number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(operatorTest.basicMath(x, y));
           

            Console.WriteLine("Enter radius of circle:\n");
            Console.WriteLine($"The area of the circle is {operatorTest.AreaOfCircle(double.Parse(Console.ReadLine()))}");
            Console.ReadLine();
            
            


        }
    }
}
