using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSortImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            var shellSort = new ShellSort();
            shellSort.Sort(array);

            //var shellSortBySedgewick = new ShellSortBySedgewick();
            //shellSortBySedgewick.Sort(array);

            //var shellSortByKnuth = new ShellSortByKnuth();
            //shellSortByKnuth.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
