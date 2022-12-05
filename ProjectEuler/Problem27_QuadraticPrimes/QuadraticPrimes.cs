using ProjectEuler.Shared;

namespace ProjectEuler.Problem27_QuadraticPrimes
{
    public static class QuadraticPrimes
    {
        public static int Main(int minA, int maxA, int minB, int maxB, bool isProduct)
        {
            var maxPrimes = 0;
            var maxPrimesProduct = 0;
            
            for (int a = minA; a <= maxA; a++)
            {
                for (int b = minB; b <= maxB; b+=2)
                {
                    var n = 0;
                    bool isPrime;
                    var currentPrimeCount = 0;
                    do
                    {
                        int value = ((n * n) + (a * n) + b); 
                        
                        isPrime = value > 0 && value.IsPrime();
                        if (isPrime)
                            currentPrimeCount++;

                        n++;
                    } while (isPrime);

                    if (currentPrimeCount >= maxPrimes)
                    {
                        maxPrimes = currentPrimeCount;
                        maxPrimesProduct = a * b;
                    }
                }
            }

            return isProduct ? maxPrimesProduct : maxPrimes;
        }
    }
}