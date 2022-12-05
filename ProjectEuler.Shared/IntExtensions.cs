namespace ProjectEuler.Shared
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int value)
        {
            var isPrime = true;
            for (var i = 2; i <= Math.Floor((double) value / 2); i++)
            {
                if (!value.IsAnEvenDivisor(i)) continue;
                isPrime = false;
                break;
            }

            return isPrime;
        }

        private static bool IsAnEvenDivisor(this int value, int divisor)
        {
            return ((decimal) value / divisor) % 1 == 0;
        } 
    }
}
