using ProjectEuler.Shared;

namespace ProjectEuler.Problem07_10001stPrime
{
    public static class Prime10001st
    {
        public static int Main()
        {
            var countPrime = 0;
            var n = -1;
            do
            {
                n += 2;
                var isPrime = (n).IsPrime();
                if (isPrime)
                    countPrime++;
            } while (countPrime < 10001);

            return n;
        }
    }
}