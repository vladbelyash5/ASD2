using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Class_Shaker_Sort
    {
        public void shakerSort(int[] array)
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
                for (int i = array.Length - 1; i > 0; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    }
                }

                // вывод в консоль
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");

                // проверка на отсортированность
                int cnt = 0;
                for (int i = 0;i < array.Length - 1;i++)
                {
                    if (array[i] <= array[i + 1])
                        cnt += 1;
                }
                if (cnt == array.Length - 1)
                {
                    flag = false;
                }
                /*if (array[0] == array.Min() && array[array.Length - 1] == array.Max())
                {
                    flag = false;
                }*/
                //Console.ReadLine();
            }
            
        }
    }
}
