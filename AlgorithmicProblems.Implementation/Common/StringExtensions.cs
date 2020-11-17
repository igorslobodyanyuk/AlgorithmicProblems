namespace AlgorithmicProblems.Implementation.Common
{
    public static class StringExtensions
    {
        public static T Convert<T>(this string value)
        {
            return (T)System.Convert.ChangeType(value, typeof(T));
        }
    }
}