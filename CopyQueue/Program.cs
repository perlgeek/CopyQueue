﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //New Queue of Integers
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);

            /*Create new array with 
            length equal to Queue's element count*/
            
            int[] array = new int[queue.Count];

            //Copy the Queue to the Array
            queue.CopyTo(array, 0);
            
            //Loop through and display int[] in order
            Console.WriteLine("Array: ");
            
            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            //Loop through int array in reverse order
            
            Console.WriteLine("Array reverse order: ");
            for (int i = array.Length -1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);

            }


        }
    }
}
