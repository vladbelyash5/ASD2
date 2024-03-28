using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Class_Insert_Sort
    {
        public void InsertSort(int[] arr)
        {
            int index;
            int currentNumber;
            
            for (int i = 0; i < arr.Length; i++)
            {
                index = i;
                currentNumber = arr[i];
                while (index > 0 && currentNumber < arr[index - 1])
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = currentNumber;
            }

            // вывод в консоль
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
