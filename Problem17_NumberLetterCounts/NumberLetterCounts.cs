using System;

namespace Problem17_NumberLetterCounts
{
    public class NumberLetterCounts
    {
        public int Main(int number, int startNumber = 1)
        {
            var result = 0;

            for(var i = startNumber; i <= number; i++)
            {
                var stringValue = NumberStringExtensions.GetNumberString(i);
                Console.WriteLine(stringValue);
                result += stringValue.Length;
            }

            return result;
        }
    }
}
