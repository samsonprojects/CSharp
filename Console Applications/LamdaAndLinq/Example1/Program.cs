using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0}  ", num);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
