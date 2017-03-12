using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Person
    {

        private string name;
        private SortedSet<long> phoneBook;

        public string Name
        {
            get; set;
        }

        public SortedSet<long> PhoneBook
        {
            get { return this.phoneBook; }
           
        }

        public Person(string myName, params long[] numbers)
        {
            Name = myName;
            for(int i = 0; i<numbers.Length; i++)
            {
                phoneBook.Add(numbers[i]); 
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
