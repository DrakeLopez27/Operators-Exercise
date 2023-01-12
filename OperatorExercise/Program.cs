using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }

        static void Main(string[] args)
        {

            int a = 17; int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17/4 is {quotient} remainder {remainder}");
            }
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var resultAreaOfCir = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius {radius} is {resultAreaOfCir}");
        }
    }
}


         
     



        
        
        

