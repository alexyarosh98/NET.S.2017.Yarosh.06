using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtensions
{
    public static class Sorting
    {
        /// <summary>
        /// Sort an array with the help of bubble sort by the sums of lines
        /// </summary>
        /// <param name="array">users array</param>
        /// <param name="reverseOrder">include reverse order or not</param>
        /// <exception cref="ArgumentNullException">array must be not null</exception>
        /// <exception cref="ArgumentException">array length must be not 0</exception>
        public static void BubbleSortBySum(int[][]array, bool reverseOrder=false)
        {
            CheckArguments(array);
            Array.Copy(BubbleSort(array,CompareBySums,reverseOrder), array, array.Length);
        }
        /// <summary>
        /// Sort an array with the help of bubble sort by max element in lines
        /// </summary>
        /// <param name="array">users array</param>
        /// <param name="reverseOrder">include reverse order or not</param>
        /// <exception cref="ArgumentNullException">array must be not null</exception>
        /// <exception cref="ArgumentException">array length must be not 0</exception>
        public static void BubbleSortByMaxElement(int[][]array, bool reverseOrder = false)
        {
            CheckArguments(array);
            Array.Copy(BubbleSort(array,CompareByMaxElements,reverseOrder),array,array.Length);
        }

        /// <summary>
        /// Sort an array with the help of bubble sort by min element in lines
        /// </summary>
        /// <param name="array">users array</param>
        /// <param name="reverseOrder">include reverse order or not</param>
        /// <exception cref="ArgumentNullException">array must be not null</exception>
        /// <exception cref="ArgumentException">array length must be not 0</exception>
        public static void BubbleSortByMinElement(int[][]array, bool reverseOrder = false)
        {
            CheckArguments(array);
            Array.Copy(BubbleSort(array,CompareByMinElements,reverseOrder),array,array.Length);
        }

        private static int[][] BubbleSort(int[][] array, Comparison<int[]> comparer,bool reverseOrder)
        {
            int[] temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[i], array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            if(reverseOrder) Array.Reverse(array);

            return array;
        }

        private static void CheckArguments(int[][]array)
        {
            if(array==null) throw new ArgumentNullException($"{nameof(array)} must be not null");
            if(array.Length==0) throw new ArgumentException($"size of {nameof(array)} must be not 0");
        }

        private static int CompareBySums(int[] arr1, int[] arr2) => arr1.Sum().CompareTo(arr2.Sum());
        private static int CompareByMaxElements(int[] arr1, int[] arr2) => arr1.Max().CompareTo(arr2.Max());
        private static int CompareByMinElements(int[]arr1,int[]arr2)=> arr1.Min().CompareTo(arr2.Min());
    }
}


