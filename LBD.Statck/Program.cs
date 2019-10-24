using System;

namespace LBD.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayStackDemo();

            LinkedStackDemo();

            Console.ReadKey();
        }

        public static void ArrayStackDemo()
        {
            ArrayStack<int> arrayStack = new ArrayStack<int>(5);
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(1, 100);
                arrayStack.Push(num);
                Console.WriteLine("入栈 "+ num);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("出栈 "+arrayStack.Pop());
            }


        }

        public static void LinkedStackDemo()
        {
            LinkStack<int> linkStack = new LinkStack<int>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(1, 100);
                linkStack.Push(num);
                Console.WriteLine("入链表栈 " + num);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("出链表栈 " + linkStack.Pop());
            }

        }

    }
}
