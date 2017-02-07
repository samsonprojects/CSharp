using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableWithMultipleValues
{
    class ValuesCollection
    {
        private List<int> KeyList;//adding an element is constant 

        public List<int> AddNewkey(int NewKey)
        {
            KeyList.Add(NewKey);
            return KeyList;
        }

        public ValuesCollection()
        {
            this.KeyList = new List<int>();
        }

        public ValuesCollection(params int[] list)
        {
            KeyList = new List<int>();
            for(int i = 0; i < list.Length; i++)
            {
                this.KeyList.Add(list[i]);
            }
        }

        public void PrintKeys()
        {
            foreach(int num in KeyList)
            {
                Console.WriteLine(num);
            }
        }
        static void Main(string[] args)
        {
            ValuesCollection TestCase1 = new ValuesCollection(1, 2, 3, 4);
            TestCase1.PrintKeys();
            Console.ReadLine();

        }
    }
}
