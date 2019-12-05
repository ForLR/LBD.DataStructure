using LBD.Sorting.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBD.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = new int[] { 3,2,4,1,5};

            int[] data1 = new int[] { 3, 2, 4, 1, 5 };
            CodeTimer.Initialize();

            BubbleSort(data);

            ShellSort(data1);

         
            Console.ReadKey();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void BubbleSort<T>(T[] arr) where T: IComparable
        {
            CodeTimer.Time("BubbleSort", 1, () => {
                int len = arr.Length;
                if (len == 0) return;

                for (int i = 0; i < len; i++)
                {
                    for (int j = i+1; j < len; j++)
                    {
                        if (arr[i].CompareTo(arr[j])>0)
                        {
                            var temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                 
                    }
                }
            });
        }

        public static void ShellSort<T>(T[] arr) where T : IComparable
        {
            CodeTimer.Time("ShellSort", 1, () => {
                int i, j, d;
                T temp;

                for (d = arr.Length / 2; d >= 1; d = d / 2)
                {
                    for (i = d; i < arr.Length; i++)
                    {
                        j = i - d;
                        temp = arr[i];

                        while (j >= 0 && temp.CompareTo(arr[j]) < 0)
                        {
                            arr[j + d] = arr[j];
                            j = j - d;
                        }

                        arr[j + d] = temp;
                    }
                }
            });
        }
    }

   
}
