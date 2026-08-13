using System.Reflection.Metadata;

namespace TileCostCalculator
{
    internal class Program
    { 
        static void Main()
        {
            double costPerFlooringUnit = 1.0;
            double area = 1.0;
            const int AVERAGE_FLOORING_FOOTAGE_PER_HOUR = 20;
            const double LABOR_COST_PER_HOUR = 86.00;
            const string rec = "rectangle";
            const string circ = "circle";


            // ask user for shape of the room: rectangle or circle
            Console.Write("Please enter the shape of the room (rectangle or circle): ");
            string? shape = Console.ReadLine();  //will this if/else statement be enough to handle null input or should I add a check for null input?

            if (shape == rec)
            {
                double length = 1.0;
                double width = 1.0;
                Console.Write("Enter room length in feet: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter room width in feet: ");
                width = Convert.ToDouble(Console.ReadLine());
                area = length * width;

            }
            else if (shape == circ)
            {
                double radius = 1.0;
                double circleArea = Math.PI * radius * radius;
                Console.Write("Radius of the circle in feet: ");
                radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radius * radius;

            }
            else
            {
                Console.WriteLine($"Shape not recognized. Please enter either {rec} or {circ} next time.");
                return;
            }

            Console.WriteLine($"Room area: {area} square feet");

            Console.Write ("Enter cost per flooring unit: ");
            costPerFlooringUnit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ("Cost to cover area with flooring: " + (area * costPerFlooringUnit));

            Console.WriteLine ("Cost of labor to install flooring: " + (area / AVERAGE_FLOORING_FOOTAGE_PER_HOUR * LABOR_COST_PER_HOUR));

        }
    }
}