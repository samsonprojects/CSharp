using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableWithMultipleValues
{
    /// <summary>
    /// Hash-tables do not allow storing more than one value in a key.
    /// How can we get around this restriction?
    /// Define a class to hold multiple values in a hash-table.
    /// </summary>
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

        /// <summary>
        /// add multiple values to the list
        /// </summary>
        /// <param name="list"></param>
        public ValuesCollection(params int[] list)
        {
            KeyList = new List<int>();
            for(int i = 0; i < list.Length; i++)
            {
                this.KeyList.Add(list[i]);
                
            }
        }

        public List<int> SortList()
        {
            this.KeyList.Sort();
            return this.KeyList;
        }
        public void PrintKeys()
        {
            foreach(int num in KeyList)
            {
                Console.Write(num);
            }
        }
    }
}
