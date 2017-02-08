using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableWithMultipleValues
{
    public class MultiKeyHastable
    {
        static void Main()
        {
            ValuesCollection KeyCase1 = new ValuesCollection(1, 2, 3, 4);
            ValuesCollection KeyCase2 = new ValuesCollection(8, 3, 4,5);
            Dictionary<ValuesCollection, string> MyhashDict = 
                new Dictionary<ValuesCollection, string>();
            MyhashDict.Add(KeyCase1, "Football");
            MyhashDict.Add(KeyCase2, "Rugby");

            foreach(KeyValuePair<ValuesCollection,string> element in MyhashDict)
            {
                ValuesCollection CurrentKey = element.Key;
                Console.Write("Key is : ");
                CurrentKey.PrintKeys();
                Console.Write(" Value is: {0}",element.Value);
                Console.WriteLine();
            }

            Console.WriteLine("lucky sport for today is: {0}", MyhashDict[KeyCase2]);

            KeyCase2.SortList();
            KeyCase2.PrintKeys();
            


            //KeyCase1.PrintKeys();
            Console.ReadLine();

        }
    }
}
