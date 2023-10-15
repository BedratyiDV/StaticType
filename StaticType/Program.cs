using System.Diagnostics.Metrics;

namespace StaticType
{
    public class Program
    {
        static void Main(string[] args)
        {
           Point point1 = new Point(-7, 12);
           Point point2 = new Point(340, -70);
            point2.XCoordinate = -10;
            point2.YCoordinate = 20;

            Console.WriteLine($"Coordinats of point1: X = {point1.XCoordinate}, Y = {point1.YCoordinate}");
            Console.WriteLine($"Coordinats of point1: X = {point2.XCoordinate}, Y = {point2.YCoordinate}");
            Console.WriteLine($"Counter current value: Counter = {Point.Counter}");

            Point point3 = new Point(17, 8);
            Point point4 = new Point(2, 31);

            Console.WriteLine($"Counter current value: Counter = {Point.Counter}");
            Console.WriteLine($"Distance between point 3 and point 4 is" +
                    $" {Calculation.GetDestancebetweenPoints(point3, point4)}");

            Calculation calculation = new(); 
            Console.WriteLine($"Distance between internal point and point 3 is" +
                    $" {calculation.GetDistanceToPoint(point3)}");
            Console.WriteLine($"Distance between internal point and point 4 is" +
                    $" {calculation.GetDistanceToPoint(point4)}");



        }
    }
}