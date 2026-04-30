namespace Ex_03_16
{
    public class Calculator
    {
        public static int Div(int x, int y)
        {
            if (x < 0)
            {
                throw new InputParameterLessThanZeroException(param: x);
            }

            return x / y;
        }
    }
}
