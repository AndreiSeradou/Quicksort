using System;
using System.Collections.Generic;

namespace Quicksort
{
    internal class Sort
    {
        public static void ShakerSort<T>(ref List<T> list)
            where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                return;
            }
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                for (int i = right; i > left; --i)
                {
                    if (list[i - 1].CompareTo(list[i]) > 0)
                    {
                        T temp;
                        temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                    }
                }
                ++left;
                for (int i = left; i < right; ++i)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        T temp;
                        temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                    }
                }
                --right;
            }
        }
    }
}