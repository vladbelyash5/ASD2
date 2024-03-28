using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Class_Selection_Sort
    {
        public void SelectionSort(int[] array)
        {
            int min;
            int temp;
            for(int i = 0; i < array.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                temp = array[min];
                array[min] = array[i];
                array[i] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
