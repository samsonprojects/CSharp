using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Implement the following extension methods for the classes,
/// implementing the interface IEnumerable<T>: Sum(), Min(), Max(), Average(). 
/// </summary>

namespace ConsoleApplication2
{
    public static class IEnumerableExtensions
    {
        
        public static int Sum(this IEnumerable<int> enumeration)
        {
            int sum = 0;
            try
            {
                
                foreach (int num in enumeration)
                {
                    sum += num;
                }
            }
            catch(Exception e)
            {
                throw new ApplicationException("Invalid enumeration values type , must be of type INT", e);
            }

            return sum;
            
        }

        public static int Min(this IEnumerable<int> enumeration)
        {
            int min = 0;
            try
            {

            }
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 5, 6, 8, 9, 3, 2 };
            Console.Write(numbers.Sum());
            Console.ReadLine();
        }
    }
}
