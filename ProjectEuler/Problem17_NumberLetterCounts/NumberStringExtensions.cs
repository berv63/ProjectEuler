namespace ProjectEuler.Problem17_NumberLetterCounts
{
    public static class NumberStringExtensions
    {
        public static string GetNumberString(int number)
        {
            if (number / 1000 >= 1)
            {
                var thousandNumber = (int)Math.Floor(number / 100m);
                return GetSingleNumber(thousandNumber) + NumberLetterStringContants.Thousand +
                    (number % 1000 > 0 ?
                     GetNumberString(number % 1000) :
                     ""); ;
            }
            
            if (number / 100 >= 1)
            {
                var hundredNumber = (int)Math.Floor(number / 100m);
                return GetSingleNumber(hundredNumber) + NumberLetterStringContants.Hundred +
                    (number % 100 > 0 ?
                     NumberLetterStringContants.And + GetNumberString(number % 100) :
                     "");
            }

            if (number <= 19)
                return GetSingleNumber(number);
            else
            {
                var tensNumber = (int)Math.Floor(number / 10m);
                return NumberLetterStringContants.HardCodedTens[tensNumber] + GetSingleNumber(number % 10);
            }
        }

        public static string GetSingleNumber(int number)
        {
            return NumberLetterStringContants.HardCoded[number];
        }
    }
}
