using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Class_Bubble_Sort
    {
        public void bubbleSort(int[] array)
        {

            bool flag = true;
            while (flag)
            {
                // сортировка
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }

                // вывод в консоль
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");

                // проверка на отсортированность
                if (array[0] == array.Min() && array[array.Length - 1] == array.Max())
                {
                    flag = false;
                }
            }
        }
    }
}
