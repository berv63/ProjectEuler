using ProjectEuler.Shared;

namespace ProjectEuler.Problem36_DoubleBasePalindromes
{
    public static class DoubleBasePalindromes
    {
        public static int Main(int maxValue)
        {
            var result = new List<int>();
            for (int i = 0; i < maxValue; i++)
            {
                if(IsDoubleBasePalindrome(i))
                    result.Add(i);
            }

            return result.Sum();
        }

        public static bool IsDoubleBasePalindrome(int value)
        {
            return value.IsPalindrome() && value.ToBinary(0).IsPalindrome();
        }
    }
}