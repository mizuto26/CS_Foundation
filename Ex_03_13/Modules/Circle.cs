namespace Ex_03_13.Modules
{
    public class Circle
    {
        public static double PI = 3.14;
        public int radius;

        public double AreaCalculation()
        {
            return radius * radius * PI;
        }

        public static double AreaCalculation(int radius)
        {
            return radius * radius * PI;
        }
    }
}
