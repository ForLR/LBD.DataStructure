using System;

namespace LBD.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=Searn(new int[3] { 5,3,20},3);
            Console.WriteLine(result) ;
            Console.ReadKey();
        }

        public static int Searn(int[] arr,int value)
        {
            int i;
            arr[0] = value;
            i = arr.Length-1;
            while (arr[i]!=value)
            {
                i--;
            }
            return i;
        }
    }
}
