using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSortImplementations
{
    public class ShellSortByKnuth : ISort
    {
        public void Sort(int[] arr)
        {
            int gap;
            for (gap = 1; gap < arr.Length / 3; gap = gap * 3 + 1);

            for (; gap > 0; gap = (gap - 1) / 3)
            {
                for (int i = gap; i < arr.Length; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];

                    arr[j] = temp;
                }
            }
        }
    }
}
