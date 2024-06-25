using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    public class ShellSortAndRangeArray<T> where T : IComparable
    {
        private T[] array;
        public ShellSortAndRangeArray(T[] array)
        {
            this.array = array;
        }
        public void ShellSort()
        {
            int n = array.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    T temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap].CompareTo(temp) > 0; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
                gap /= 2;
            }
        }
        public dynamic GetRange()
        {
            dynamic min = array[0];
            dynamic max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max - min;
        }
        public T[] GetArray()
        {
            return array;
        }
    }
}
