using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayExtensions
{
    public interface IComparer
    {
        int Compare(int[] arr1, int[]arr2);
    }

    public class ComparerBySum : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)=> arr1.Sum().CompareTo(arr2.Sum());
    }

    public class ComparerByMaxValue : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)=> arr1.Max().CompareTo(arr2.Max());
    }

    public class CompareByMinValue : IComparer
    {
        public int Compare(int[]arr1,int[]arr2)=> arr1.Min().CompareTo(arr2.Min());
    }

    public static class Comparers
    {
        public static int CompareBySums(int[] arr1, int[] arr2) => arr1.Sum().CompareTo(arr2.Sum());
        public static int CompareByMaxElements(int[] arr1, int[] arr2) => arr1.Max().CompareTo(arr2.Max());
        public static int CompareByMinElements(int[] arr1, int[] arr2) => arr1.Min().CompareTo(arr2.Min());
    }
}