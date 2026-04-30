namespace Ex_03_13;

using static Ex_03_13.Modules.Circle;
using Ex_03_13.Modules;

static class Program
{
    static void Main(string[] args)
    {

        Circle circle = new()
        {
            radius = 5
        };

        Console.WriteLine($"{circle.radius} * {circle.radius} * {PI} = {circle.AreaCalculation()}");
        Console.WriteLine($"{circle.radius} * {circle.radius} * {PI} = {AreaCalculation(radius: 5)}");

        PI = 3;

        Console.WriteLine($"{circle.radius} * {circle.radius} * {PI} = {circle.AreaCalculation()}");
        Console.WriteLine($"{circle.radius} * {circle.radius} * {PI} = {AreaCalculation(radius: 5)}");
    }
}
