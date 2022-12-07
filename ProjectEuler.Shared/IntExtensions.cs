namespace ProjectEuler.Shared
{
    public static class IntExtensions
    {
        public static bool ContainsDigit(this int value, int digit)
        {
            return value.ToString().Contains(digit.ToString());
        }

        public static int GetDigitLocation(this int value, char digit)
        {
            return string.Join("", value.ToString().Reverse()).IndexOf(digit);
        }

        public static bool IsDigitOneSmallerThanDigitTwo(this int number)
        {
            var firstDigit = int.Parse(number.ToString()[0].ToString());
            var secondDigit = int.Parse(number.ToString()[1].ToString());

            return firstDigit < secondDigit;
        }
        
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

        public static bool IsPandigital(this int value)
        {
            return value.ToString().Distinct().Count() == value.ToString().Length;
        }

        public static bool IsPalindrome(this int value)
        {
            return value.ToString().IsPalindrome();
        }

        public static string ToBinary(this int number, int leftPadding)
        {
            return Convert.ToString(number, 2).PadLeft(leftPadding, '0');
        }

        public static int RoundToNearest(this int value, int valueToRoundTo)
        {
            return value / valueToRoundTo * valueToRoundTo;
        }

        public static List<int> GetDigitsAsList(this int value)
        {
            return value.ToString().Select(x => int.Parse(x.ToString())).ToList();
        }
    }
}
