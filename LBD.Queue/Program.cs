using System;

namespace LBD.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            
   
            Random random = new Random();
            #region 链表队列
            LinkQueue<int> linkQueue = new LinkQueue<int>();
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(1, 50);
                linkQueue.EnQueue(num);
                Console.WriteLine("链表入队" + num);
            }
            linkQueue.clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("链表" + linkQueue.DeQueue());
            }
            Console.WriteLine("现在链表队列长度" + linkQueue.Size);
            linkQueue.EnQueue(random.Next(1, 100));
            Console.WriteLine("现在链表列长度" + linkQueue.Size);

            #endregion
            #region 数组队列

            ArrayQueue<int> arrayQueue = new ArrayQueue<int>(5);
           
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(1, 50);
                arrayQueue.EnQueue(num);
               
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("出队"+arrayQueue.DeQueue());
            //}
            Console.WriteLine("现在数组队列长度" + arrayQueue.Size);
            arrayQueue.EnQueue(random.Next(1,100));
            Console.WriteLine("现在数组队列长度" + arrayQueue.Size);
            #endregion 
            Console.ReadKey();
        }
    }
}
