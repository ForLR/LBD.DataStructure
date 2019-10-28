using System;

namespace LBD.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var result=Searn(new int[] { 5,3,20,7,8,22},4);
            Console.WriteLine(result) ;
            Console.ReadKey();
        }


        public static int Searn(int[] arr,int value)
        {
            if (arr[0]==value)
            {
                return 1;
            }
            int i;
            //arr[0] = value;
            i = arr.Length-1;
            while (arr[i]!=value&&i!=0)
            {
                i--;
            }
            return i;
        }
    }
}
