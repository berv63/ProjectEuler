namespace ProjectEuler.Shared
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string value)
        {
            var other = string.Join("", value.ToString().Reverse());
            return value == other;
        }
    }
}
