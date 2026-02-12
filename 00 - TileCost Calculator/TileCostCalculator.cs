using static System.Collections.Specialized.BitVector32;

namespace _00___TileCost_Calculator
{
    internal class Program
    {
        const double SQUARE_FEET_PER_HOUR = 20;
        const double PRICE_PER_HOUR = 86;
        const int OPTION_RECTANGLE = 1;
        const int OPTION_TRIANGLE = 2;
        const int OPTION_NONE = 0;

        static void Main(string[] args)
        {
            int shape = GetShapeSelection(args);
            double surface = CalculateSurface(shape);
            WriteCost(surface);
        }

        static int GetShapeSelection(string[] args)
        {
            Console.WriteLine("Please pick a shape:");
            Console.WriteLine($"{OPTION_RECTANGLE} - Rectangle");
            Console.WriteLine($"{OPTION_TRIANGLE} - Triangle");
            int selection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return selection;
        }

        static double CalculateSurface(int shape)
        {
            switch (shape)
            {
                case OPTION_RECTANGLE:
                    return PerformCalculationForRectangle();
                case OPTION_TRIANGLE:
                    return PerformCalculationForTriangle();
                default:
                    return OPTION_NONE;
            }
        }

        static double PerformCalculationForRectangle()
        {
            Console.WriteLine("Please enter the width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            return width * length;
        }

        static double PerformCalculationForTriangle()
        {
            Console.WriteLine("Please enter the width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            return width * length / 2.0;
        }

        static void WriteCost(double surface)
        {
            double cost = surface * PRICE_PER_HOUR / SQUARE_FEET_PER_HOUR;
            Console.WriteLine($"The surface is: {surface}");
            Console.WriteLine($"The cost is: ${cost}");
        }
    }
}
