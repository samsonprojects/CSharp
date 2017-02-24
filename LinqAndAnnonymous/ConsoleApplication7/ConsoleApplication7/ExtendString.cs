using System.Linq;
using System;
using System.Collections.Generic;

using System.Text;

/// <summary>
/// Write an extension method for the class String that capitalizes all letters,
/// which are the beginning of a word in a sentence in English. For example:
/// "this iS a Sample sentence." should be converted to "This Is A Sample Sentence.".
/// </summary>

namespace ConsoleApplication7
{
    public static class ExtendString
    {

        public static void CapitaliseFirstLetter(this string sentence)
        {
            string LowerCase = sentence.ToLower();
            from culture
            in
            

            
            Console.Write(LowerCase);

        }

        public static string CapitaliseFirstLetter(string word)
        {
            string newWord = "";
            
            for(int i=0; i<word.Length; i++)
            {
                if (i == 0)
                {
                    
                }
            }
        }
        static void Main(string[] args)
        {
            string TestString = "this iS a Sample sentence";
            TestString.CapitaliseFirstLetter();
            Console.ReadLine();

            

            
        }
    }
}
