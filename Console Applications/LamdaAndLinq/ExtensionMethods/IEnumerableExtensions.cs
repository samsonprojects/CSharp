using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");

            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(" , ");
            }

            if (result.Length > 1)
                result.Remove(result.Length - 2, 2);
            result.Append("]");
            return result.ToString();
        }

        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreaseWith(5);
            Console.WriteLine(numbers.ToString<int>());
        }
    }
}
