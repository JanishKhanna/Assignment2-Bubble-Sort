using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[]
            {
                8, -1, 7, 9, 4, -10, 0, 6, 2
            };

            int sortedArray;

            for (int z = 0; z < myArray.Length; z++)
            {
                for (int x = 0; x < myArray.Length - 1; x++)
                {
                    if (myArray[x] > myArray[x + 1])
                    {
                        sortedArray = myArray[x];
                        myArray[x] = myArray[x + 1];
                        myArray[x + 1] = sortedArray;
                    }
                }
            }

            Console.WriteLine("Result with Bubble Sort: ");

            foreach (var output in myArray)
            {
                if (output == myArray[myArray.Length - 1])
                {
                    Console.Write(output);
                }
                else
                {
                    Console.Write(output + ", ");
                }
            }
            Console.ReadLine();
        }
    }
}

