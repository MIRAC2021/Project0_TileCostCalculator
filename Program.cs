namespace TileCostCalculator
{
    internal class Program
    { 
        static void Main()
        {
            double length = 1.0;
            double width = 1.0;
            double costPerFlooringUnit = 1.0;
            double area = length * width;

            Console.WriteLine ("Enter room length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ("Enter room width: ");
            width = Convert.ToDouble(Console.ReadLine());

            area = length * width;
            Console.WriteLine($"Room area: {area}");

            Console.WriteLine ("Enter cost per flooring unit: ");
            costPerFlooringUnit = Convert.ToDouble(Console.ReadLine());

        }
    }
}