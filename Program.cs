using System.Reflection.Metadata;

namespace TileCostCalculator
{
    internal class Program
    { 
        static void Main()
        {
            double length = 1.0;
            double width = 1.0;
            double costPerFlooringUnit = 1.0;
            double area = 1.0; // is it better to use one variable for circle and rectangle areas or separate variables?
            double radius = 1.0;
            double circleArea = Math.PI * radius * radius;
            int AVERAGEFLOORINGFOOTAGEPERHOUR = 20;
            double LABORCOSTPERHOUR = 86.00;

            // ask user for shape of the room: rectangle or circle
            Console.Write("Please enter the shape of the room (rectangle or circle): ");
            string shape = Console.ReadLine();  //will this if/else statement be enough to hadle null input or should I add a check for null input?

            if (shape == "rectangle")
            {
                Console.Write("Enter room length in feet: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter room width in feet: ");
                width = Convert.ToDouble(Console.ReadLine());
                area = length * width;

            }
            else if (shape == "circle")
            {
                Console.Write("Radius of the circle in feet: ");
                radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radius * radius;

            }
            else
            {
                Console.WriteLine("Shape not recognized. Please enter either 'rectangle' or 'circle' next time.");  //Is there a way I can make the code go back to the original "if" statement instead of exiting the program? I want to give the user another chance to enter a valid shape.
                Environment.Exit(0);
            }

            Console.WriteLine($"Room area: {area} square feet");

            Console.Write ("Enter cost per flooring unit: ");
            costPerFlooringUnit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ("Cost to cover area with flooring: " + (area * costPerFlooringUnit));

            Console.WriteLine ("Cost of labor to install flooring: " + (area / AVERAGEFLOORINGFOOTAGEPERHOUR * LABORCOSTPERHOUR));

        }
    }
}