using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Class_Radix_Sort
    {
        // Method to perform Radix Sort
        public void Sort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];

            // Loop through each bit of the integers (from the most significant to the least significant bit)
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;

                // Iterate through the array to classify the elements based on the current bit
                for (i = 0; i < arr.Length; ++i)
                {
                    // Check the current bit status for the integer
                    bool move = (arr[i] << shift) >= 0;

                    // If the current bit matches the required position
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i]; // Move the element to the left side of the array
                    else
                        tmp[j++] = arr[i]; // Move the element to the temporary array
                }

                // Copy the elements from the temporary array to the original array at the end
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
    }
}
