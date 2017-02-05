﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "ovean", "Bear", "money", "happiness" };
            Queue<HashSet<string>> subsetsQueue = 
                new Queue<HashSet<string>>();
            HashSet<string> emptySet = new HashSet<string>();
            subsetsQueue.Enqueue(emptySet);

            while(subsetsQueue.Count> 0)
            {
                HashSet<String> subset = subsetsQueue.Dequeue();

                //Print current subset
                Console.Write("{ ");
                foreach(string word in subset)
                {
                    Console.Write("{0} " ,word);

                }
                Console.WriteLine("}");
                //Generate and enqueue all possible child subsets
                foreach(string element in words)
                {
                    if (!subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        subsetsQueue.Enqueue(newSubset);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
