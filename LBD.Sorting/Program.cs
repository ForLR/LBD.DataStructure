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

            int[] data = new int[] { 3, 2, 4, 1, 5 };

            int[] data1 = new int[] { 3, 2, 4, 1, 5 };
             CodeTimer.Initialize();

            SelectSort(data);
            
            //InsertSort(data);

            //BubbleSort(data);

            //ShellSort(data1);


            Console.ReadKey();
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void BubbleSort<T>(T[] arr) where T : IComparable
        {
            CodeTimer.Time("BubbleSort", 1, () => {
                int len = arr.Length;
                if (len == 0) return;

                for (int i = 0; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (arr[i].CompareTo(arr[j]) > 0)
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


        /// <summary>
        /// 找到最小值往左边以此比较 到对应位置插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void InsertSort<T>(T[] arr) where T : IComparable
        {
            if (arr == null || arr.Length < 1)
            {
                return;
            }
            int inner;
            T temp;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                inner = i;
                while (inner > 0 && arr[inner - 1].CompareTo(temp) > 0)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;

            }

        }
       

        /// <summary>
        /// 循环查找最小值 互换找到的位置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        public static void  SelectSort<T>(T[] arr) where T : IComparable
        {
            if (arr == null || arr.Length < 1)
            {
                return;
            }
            T temp;
            int min;
            for (int outer = 0; outer < arr.Length; outer++)
            {
                min = outer;
                for (int inner = outer+1; inner < arr.Length; inner++)
                {
                    if (arr[min].CompareTo(arr[inner])>0)
                    {
                        min = inner;  
                    }
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }

        }
    }

   
}
