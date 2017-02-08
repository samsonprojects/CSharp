using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Implement a data structure, which can quickly do the following two operations:
/// add an element and extract the smallest element. 
/// The structure should accept adding duplicated elements. 
/// </summary>
namespace SortedSetApplictionRetrieveSmallest
{/// <summary>
/// this data structure contains one Dynamic List
/// </summary>
    public class FilterSmallest 
    {
        private List<int> MainList; //generic list to accept items
        private SortedSet<List<int>> Set = new SortedSet<List<int>>();

        public FilterSmallest()
        {
            this.MainList = new List<int>();
            this.Set.Add(MainList);
            
        }

        /// <summary>
        /// add a new list element which is part of the set
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<int> AddNewSetElement(int num)
        {
            this.MainList.Add(num);
            return this.MainList;
        }

        /// <summary>
        /// Remove smallest element in the set
        /// </summary>
        /// <returns></returns>
        public List<int> RemoveSmall()
        {
            int small = this.MainList.Min();
            this.MainList.Remove(small);

            return this.MainList;
        }

        public void PrintSet()
        {
            foreach(List<int> arry in Set)
            {
                foreach(int number in arry)
                {
                    Console.Write("[{0}]", number);
                }
            }
        }

        static void Main(string[] args)
        {
            FilterSmallest TestCaseSet = new FilterSmallest();
            TestCaseSet.AddNewSetElement(4);
            TestCaseSet.PrintSet();
            
            Console.ReadLine();
            
        }
    }
}
