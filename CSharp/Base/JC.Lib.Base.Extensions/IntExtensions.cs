namespace Base.Extensions
{
    public static class IntExtensions
    {
        public static int AsEven(this int value, bool increase = true)
        {
            if ((value & 1) is 0)
                return value;

            else
                return increase ? value + 1 : value - 1;
        }
    }
}
