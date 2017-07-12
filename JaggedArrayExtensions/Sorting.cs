using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtensions
{
    public class Sorting
    {
        /// <summary>
        /// Sort an array with the help of bubble sort by comparer-logic
        /// </summary>
        /// <param name="array">users array</param>
        /// <param name="comparer">logic of comapring lines in array</param>
        /// <param name="reverseOrder">an oppotunity to make reverse order</param>
        /// <returns></returns>
        public static void BubbleSort(int[][] array, IComparer comparer, bool reverseOrder=false)
        {
            CheckArguments(array,comparer);

            int[] temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            if (reverseOrder) Array.Reverse(array);
        }

        //public static class Sorting
        //{
        //    /// <summary>
        //    /// Sort an array with the help of bubble sort by the sums of lines
        //    /// </summary>
        //    /// <param name="array">users array</param>
        //    /// <param name="reverseOrder">include reverse order or not</param>
        //    /// <exception cref="ArgumentNullException">array must be not null</exception>
        //    /// <exception cref="ArgumentException">array length must be not 0</exception>
        //    public static void BubbleSortBySum(int[][]array, bool reverseOrder=false)
        //    {
        //        CheckArguments(array);
        //        Array.Copy(BubbleSort(array,Comparers.CompareBySums,reverseOrder), array, array.Length);
        //    }
        //    /// <summary>
        //    /// Sort an array with the help of bubble sort by max element in lines
        //    /// </summary>
        //    /// <param name="array">users array</param>
        //    /// <param name="reverseOrder">include reverse order or not</param>
        //    /// <exception cref="ArgumentNullException">array must be not null</exception>
        //    /// <exception cref="ArgumentException">array length must be not 0</exception>
        //    public static void BubbleSortByMaxElement(int[][]array, bool reverseOrder = false)
        //    {
        //        CheckArguments(array);
        //        Array.Copy(BubbleSort(array,Comparers.CompareByMaxElements,reverseOrder),array,array.Length);
        //    }

        //    /// <summary>
        //    /// Sort an array with the help of bubble sort by min element in lines
        //    /// </summary>
        //    /// <param name="array">users array</param>
        //    /// <param name="reverseOrder">include reverse order or not</param>
        //    /// <exception cref="ArgumentNullException">array must be not null</exception>
        //    /// <exception cref="ArgumentException">array length must be not 0</exception>
        //    public static void BubbleSortByMinElement(int[][]array, bool reverseOrder = false)
        //    {
        //        CheckArguments(array);
        //        Array.Copy(BubbleSort(array,Comparers.CompareByMinElements,reverseOrder),array,array.Length);
        //    }

        //    private static int[][] BubbleSort(int[][] array, Comparison<int[]> comparer,bool reverseOrder)
        //    {
        //        int[] temp;
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = i + 1; j < array.Length; j++)
        //            {
        //                if (comparer(array[i], array[j]) > 0)
        //                {
        //                    temp = array[i];
        //                    array[i] = array[j];
        //                    array[j] = temp;
        //                }
        //            }
        //        }

        //        if(reverseOrder) Array.Reverse(array);

        //        return array;
        //    }

        private static void CheckArguments(int[][] array, IComparer comparer)
        {
            if (array == null) throw new ArgumentNullException($"{nameof(array)} must be not null");
            if (array.Length == 0) throw new ArgumentException($"size of {nameof(array)} must be not 0");
            if(comparer==null) throw new ArgumentNullException($"{nameof(comparer)} must be not null");
            foreach (int[] i in array)
            {
                if (i.Length == 0) throw new ArgumentException($"{nameof(array)} must not containt empty elements");
            }
        }

        //}
    }
}


