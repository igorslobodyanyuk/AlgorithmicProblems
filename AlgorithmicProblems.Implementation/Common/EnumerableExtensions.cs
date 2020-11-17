using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicProblems.Implementation.Common
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }
        
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
        {
            return source ?? Array.Empty<T>();
        }
    }
}