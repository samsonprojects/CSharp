using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Write a program that prints to the console all numbers from a given array (or list), 
/// that are multiples of 7 and 3 at the same time. Use the builtin extension methods 
/// with lambda expressions and then rewrite the same using a LINQ query.
/// </summary>

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>(){ 3, 21, 6, 2, 14, 42, 12, 6 };

            
            divisableN(Numbers);
            
            Console.ReadLine();
            
        }

        static void DivisableLamda(List<int> numbers)
        {
            List<int> diviseNumbers = numbers.FindAll(x => (x % 21) == 0);

            foreach (var num in diviseNumbers)
            {
                Console.Write("{0} ", num);
            }

        }

        static void divisableN( IEnumerable<int> numbers)
        {
            var calcNumbers =
                from num in numbers
                where num % 3 ==0
                where num % 7 == 0
                select num;

            foreach (var item in calcNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
