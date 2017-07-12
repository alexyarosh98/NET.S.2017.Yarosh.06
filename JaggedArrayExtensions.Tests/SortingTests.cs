using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaggedArrayExtensions.Tests
{
    [TestFixture]
    public class SortingTests
    {
        
        [TestCase(new int[]{12,0,2},new int[]{14,21,10},new int[]{-4,0,8},ExpectedResult = true)]

        public bool BubbleSortBySum_JaggedArrayWithoutEmptyLines_SortedJaggedArray(params int[][]unSortedArray)
        {
         Sorting.BubbleSort(unSortedArray,new ComparerBySum());

            for (int i = 0; i < unSortedArray.Length-1; i++)
            {
                if (unSortedArray[i].Sum() > unSortedArray[i + 1].Sum()) return false;
            }

            return true;
        }

        [TestCase(new int[] { 12, 0, 2 }, new int[] { 14, 21, 10 }, new int[] { -4, 0, 8 }, ExpectedResult = true)]

        public bool BubbleSortBySum_JaggedArrayWithoutEmptyLines_SortedJaggedArrayReversed(params int[][] unSortedArray)
        {
            Sorting.BubbleSort(unSortedArray, new ComparerBySum(),true);

            for (int i = 0; i < unSortedArray.Length - 1; i++)
            {
                if (unSortedArray[i].Sum() < unSortedArray[i + 1].Sum()) return false;
            }

            return true;
        }


        [TestCase(new int[] { 12, 0, 2 }, new int[] { 14, 21, 10 }, new int[] { -4, 0, 8 }, ExpectedResult = true)]

        public bool BubbleSortByMaxValue_JaggedArrayWithoutEmptyLines_SortedJaggedArray(params int[][] unSortedArray)
        {
            Sorting.BubbleSort(unSortedArray, new ComparerByMaxValue());

            for (int i = 0; i < unSortedArray.Length - 1; i++)
            {
                if (unSortedArray[i].Max() > unSortedArray[i + 1].Max()) return false;
            }

            return true;
        }

        [TestCase(new int[] { 12, 0, 2 }, new int[] { 14, 21, 10 }, new int[] { -4, 0, 8 }, ExpectedResult = true)]

        public bool BubbleSortByMaxValue_JaggedArrayWithoutEmptyLines_SortedJaggedArrayReversed(params int[][] unSortedArray)
        {
            Sorting.BubbleSort(unSortedArray, new ComparerByMaxValue(), true);

            for (int i = 0; i < unSortedArray.Length - 1; i++)
            {
                if (unSortedArray[i].Max() < unSortedArray[i + 1].Max()) return false;
            }

            return true;
        }

        [TestCase(new int[] { 12, 0, 2 }, new int[] { 14, 21, 10 }, new int[] { -4, 0, 8 }, ExpectedResult = true)]

        public bool BubbleSortByMinValue_JaggedArrayWithoutEmptyLines_SortedJaggedArray(params int[][] unSortedArray)
        {
            Sorting.BubbleSort(unSortedArray, new CompareByMinValue());

            for (int i = 0; i < unSortedArray.Length - 1; i++)
            {
                if (unSortedArray[i].Min() > unSortedArray[i + 1].Min()) return false;
            }

            return true;
        }
        [TestCase(new int[] { 12, 0, 2 }, new int[] { 14, 21, 10 }, new int[] { -4, 0, 8 }, ExpectedResult = true)]

        public bool BubbleSortByMinValue_JaggedArrayWithoutEmptyLines_SortedJaggedArrayReversed(params int[][] unSortedArray)
        {
            Sorting.BubbleSort(unSortedArray, new CompareByMinValue(),true);

            for (int i = 0; i < unSortedArray.Length - 1; i++)
            {
                if (unSortedArray[i].Min() < unSortedArray[i + 1].Min()) return false;
            }

            return true;
        }
    }
}
