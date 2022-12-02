using System;

namespace Problem19_CountingSundays
{
    public class CountingSundays
    {
        public int GetSundaysOfCentury(int century)
        {
            var startDate = new DateTime((century - 1) * 100 + 1, 1, 1);
            var endDate = new DateTime(century * 100, 12, 31);

            var result = 0;

            for(var date = startDate; date <= endDate; date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    result++;
            }

            return result;
        }
    }
}
