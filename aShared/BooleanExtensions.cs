using System;

namespace aShared
{
    public static class BooleanExtensions
    {
        public static bool GetRandomBool()
        {
            return new Random().NextDouble() > (double)0.5;
        }
    }
}
