using System;
using System.ComponentModel;

namespace Space
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Choose 1 to calculate the surface of triangle using height and its side");
                Console.WriteLine("Choose 2 to calculate the surface of triangle using its sides");

                string intialOption = Console.ReadLine();

                if (intialOption == "2")
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

                        double heightA = s / a * 2; ;
                        double heightB = s / b * 2;
                        double heightC = s / c * 2;
                        Console.WriteLine($"Height A is {heightA}");
                        Console.WriteLine($"Height B is {heightB}");
                        Console.WriteLine($"Height C is {heightC}");
                        Console.WriteLine($"Triangle square is {s}");
                    }
                    else
                    {
                        Console.WriteLine("Sides don't make the triangle");
                    }
                }
                else if (intialOption == "1")
                {
                    Console.Write("Enter the height -> ");
                    float height = float.Parse(Console.ReadLine());

                    Console.Write("Enter the basis of triangle - > 1");
                    float basis = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Surface of triangle is {(height * basis) / 2}");

                }

                Console.WriteLine("Choose 1 to continue or anything to quit");

                string option = Console.ReadLine();

                if (option == "1")
                    Main(args);
                else
                    return;
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Thread.Sleep(10);

        }
    }

}