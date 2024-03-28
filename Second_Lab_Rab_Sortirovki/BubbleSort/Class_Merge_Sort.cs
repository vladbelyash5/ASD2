using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Class_Merge_Sort
    {
        public void Merge(int[] a, int l, int m, int r)
        {
            /* l = индекс начала левой отсортированной части
             * m = индекс последнего элемента левой части(примерная середина массива a
             * r = индекс последнего элемента правой отсортированной части
             * left и right = массивы, куда переносим отсортированные половинки массива a*/
            
            int i, j, k;

            int n1 = m - l + 1;
            int n2 = r - m;

            int[] left = new int[n1 + 1];
            int[] right = new int[n2 + 1];
            
            for(i = 0; i < n1; i++)
            {
                left[i] = a[l + i];
            }
            
            for(j = 1; j <= n2; j++)
            {
                right[j - 1] = a[m + j];
            }

            left[n1] = int.MaxValue;
            right[n2] = int.MaxValue;

            i = 0;
            j = 0;

            for (k = l; k <= r; k++)
            {
                if (left[i] < right[j])
                {
                    a[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    a[k] = right[j];
                    j = j + 1;
                }
            }
        }

        public void MergeSort(int[] a, int l, int r)
        {
            int q;

            if (l < r)
            {
                q = (l + r) / 2;
                MergeSort(a, l, q);
                MergeSort(a, q + 1, r);
                Merge(a, l, q, r);
            }
        }
    }
}
