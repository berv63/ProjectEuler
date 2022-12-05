namespace ProjectEuler.Shared
{
    public class NotFinishedAttribute : Attribute
    {
        public NotFinishedAttribute()
        {
            throw new NotImplementedException("Unfinished problem");
        }
    }
}
