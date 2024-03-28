using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[16] { 4, 3, 6, 7, 2, 1, 9, 8, 5, 10, 14, 16, 12, 13, 17, 12 };
            // Вывод изначального массива
            Console.Write("Изначальный массив - ");
            foreach (int i in array1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();


            /*Console.WriteLine("/////Bubble sort//////");
            Class_Bubble_Sort test_Bubble = new Class_Bubble_Sort();
            test_Bubble.bubbleSort(array1);
            Console.WriteLine("////////////////////////\n\n");*/


            /*Console.WriteLine("////////Shaker sort////////////");
            Class_Shaker_Sort test_Shaker = new Class_Shaker_Sort();
            test_Shaker.shakerSort(array1);
            Console.WriteLine("////////////////////////\n\n");*/


            /*Console.WriteLine("//////Merge Sort//////");
            Class_Merge_Sort test_Merge = new Class_Merge_Sort();
            int l = 0;
            int r = array1.Length - 1;
            test_Merge.MergeSort(array1, l, r);
            // Вывод 
            foreach (int i in array1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n//////////////////////////\n\n");*/

            /*Class_Selection_Sort test_Selection = new Class_Selection_Sort();
            test_Selection.SelectionSort(array1);*/


            /*var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            tree.Add(4);

            foreach(var item in tree.Preorder())
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();

            foreach (var item in tree.Postorder())
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();

            foreach (var item in tree.Inorder())
            {
                Console.Write(item + ", ");
            }
            Console.ReadLine();*/



            /*Class_Radix_Sort test_Radix = new Class_Radix_Sort();
            test_Radix.Sort(array1);
            Console.WriteLine("\nСортированный массив: ");
            foreach (var item in array1)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine("\n");*/

            Class_Insert_Sort test_Insert = new Class_Insert_Sort();
            test_Insert.InsertSort(array1);
        }
    }
}
