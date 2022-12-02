using System;
using System.Collections.Generic;
using System.Linq;

namespace aShared
{
    public static class ListExtensions
    {
        public static List<T> CopyValues<T>(this List<T> values)
        {
            var result = new List<T>();
            for (var i = 0; i < values.Count; i++)
            {
                result.Add(values[i]);
            }

            return result;
        }
    }
}
