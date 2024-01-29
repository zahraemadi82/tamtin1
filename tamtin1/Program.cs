using System;
namespace project
{
    class Test
    {
        public static void Main()
        {
            double w = Convert.ToDouble(Console.ReadLine());
            double l = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double result = name(l, h, w);
            {
                Console.WriteLine(result);
            }


            static double name(double l, double h, double w)
            {
                double voloum = l * h * w;
                return voloum;
            }
        }
    }
}











