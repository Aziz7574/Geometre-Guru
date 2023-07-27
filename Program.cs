using System;
namespace Space
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool determiner = true;
            Console.WriteLine("Enter the sides of triangle");

            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            determiner = (a < (b + c)) && (b < (a + c)) && (c < (a + b));

            if (determiner)
            {
                float p = (a + b + c) / 2;
                double s = p * (p - a) * (p - c) * (p - b);
                s = Math.Sqrt(s);
                Console.WriteLine($"Triangle square is {s}");
            }
            else
            {
                Console.WriteLine("Sides don't make the triangle");
            }

            Console.WriteLine("Choose 1 to continue or anything to quit");

            string option = Console.ReadLine();

            if (option == "1")
                Main(args);
            else
                return;
        }
    }
}