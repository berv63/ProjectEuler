namespace ProjectEuler.Shared
{
    public static class BooleanExtensions
    {
        public static bool GetRandomBool()
        {
            return new Random().NextDouble() > (double)0.5;
        }
    }
}
