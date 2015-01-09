using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter r:");
        double r = double.Parse(Console.ReadLine());
        double area = r * r * Math.PI;
        double perimeter = 2 * r * Math.PI;
        Console.WriteLine("The perimeter is: {0:f2} см", perimeter);
        Console.WriteLine("The area is: {0:f2} см", area);
    }
}
