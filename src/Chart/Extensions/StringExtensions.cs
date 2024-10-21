using System;

namespace HelperJS.Chart.Extensions
{
    internal static class StringExtensions
    {
        public static string ToCamelCaseString(this string str)
        {
            return char.ToLower(str[0]) + str.Substring(1);
        }

        public static string ToCamelCaseString(this Enum e)
        {
            var str = e.ToString();
            return char.ToLower(str[0]) + str.Substring(1);
        }
    }
}
