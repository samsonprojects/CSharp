using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Implement an extension method Substring(int index, int length)
/// for the class StringBuilder that returns a new StringBuilder 
/// and has the same functionality as the method Substring(…) of the class String. 
/// </summary>

namespace ConsoleApplication1
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder newStr = new StringBuilder();
            try
            {
                

                if (index + length < str.Length)
                {

                    for (int i = index; i < index + length; i++)
                    {
                        newStr.Append(str[i]);
                    }

                }
                
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Write("the index and length is out of range");
            }
            return newStr;


        }
        
       
        static void Main(string[] args)
        {
            StringBuilder helloString = new StringBuilder("Hello, Extension Methods!");
            StringBuilder myStr = helloString.Substring(4, 7);
            Console.WriteLine(myStr);
            Console.ReadLine();
        }
    }
}
