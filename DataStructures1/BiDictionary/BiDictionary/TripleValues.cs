using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDictionary
{
    public class TripleValues<T>
    {
        //outer dictionary
        private Dictionary<string, Dictionary<string, T>> K1Dict =
            new Dictionary<string, Dictionary<string, T>>();

        //inner dictionary
        private Dictionary<string, T> K2Dict = new Dictionary<string, T>();

        public TripleValues(string Key1,string Key2,T Value)
        {
            this.K2Dict.Add(Key2, Value);
            this.K1Dict.Add(Key1, this.K2Dict);
        }

        public void AddTriple(string GivenKey1,string GivenKey2, T Value)
        {
            //check if key1 exist in outer dictionary
            Dictionary<string, T> CurrenVal;
            if (!K1Dict.TryGetValue(GivenKey1,out CurrenVal))
            {
                //create new key
                this.K2Dict.Add(GivenKey2, Value);
                this.K1Dict.Add(GivenKey1, K2Dict);
            }
            //check if key2 exist  within key 1's value


            // then add or create based on outcome

        }

        /// <summary>
        /// check if the given key exists within the dictionary 
        /// </summary>
        /// <param name="SearchKey1"></param>
        public void SearchByKey1(string SearchKey1)
        {
            Dictionary<string, T> FoundVal;
            if (K1Dict.TryGetValue(SearchKey1,out FoundVal))//get value of given key. returns a dictionary
            {
                //iterate through inner dictionary to print our values
                foreach(KeyValuePair<string,T> Val in FoundVal)
                {
                    Console.WriteLine("Key [{0}] , Value[{1}]", Val.Key, Val.Value);
                }
            }

        }
       


    }
   
}
