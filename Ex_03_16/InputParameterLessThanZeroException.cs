namespace Ex_03_16
{
    public class InputParameterLessThanZeroException : Exception
    {
        public InputParameterLessThanZeroException(int param)
        : base($"値1に{param}が入力されました。正の値を入力してください。")
        {

        }
    }
}