using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSortImplementations
{
    public class ShellSortBySedgewick : ISort
    {
        public void Sort(int[] arr)
        {
            List<int> gaps = new List<int>();
            gaps.Add(1);

            for (int i = 0; gaps[i] < arr.Length / 2; i++)
            {
                gaps.Add((int)Math.Pow(4, i + 1) + 3 * (int)Math.Pow(2, i) + 1);
            }

            gaps.Reverse();

            foreach (int gap in gaps)
            {
                for (int i = gap; i < arr.Length; i++)
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
