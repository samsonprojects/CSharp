using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 3, 1, 9, 7, 4, 3 };

            for( int i=0; i < arr.Length; i++)
            {
                for (int j=0; j < arr.Length-1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
