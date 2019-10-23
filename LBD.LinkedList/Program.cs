using System;

namespace LBD.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单链表
            //SingleList();
            #endregion

            #region 双链表
            DoubleLinkleList();
            #endregion

          
            Console.ReadKey();
        }

        public static void DoubleLinkleList()
        {
            DoublelinkedList<int> doublelinked = new DoublelinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(1,100);
                doublelinked.AddAfter(num);
                Console.WriteLine($"双链表添加成功{num}");
            }
            doublelinked.InsertAfter(5, 77);
            Console.WriteLine($"双链表为5节点后插入的值为77");

            doublelinked.InsertBefore(3, 101);
            Console.WriteLine($"双链表为3节点前插入的值为101");

            doublelinked.AddAfter(99);
            Console.WriteLine($"双链表尾节点之后插入99");

            doublelinked.AddBefore(111);
            Console.WriteLine($"双链表尾节点之前插入111");


           

            for (int i = 0; i < doublelinked.Count; i++)
            {
                Console.WriteLine($"双链表查找索引为:{i}值为:{doublelinked[i]}");
            }
            

        }

        public static void SingleList()
        {
            SingleLinkedList<int> singleLinked = new SingleLinkedList<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 100);
                singleLinked.Add(num);
                Console.WriteLine($"单链表添加成功{num}");
            }
            Console.WriteLine($"单链表当前的长度为{singleLinked.Count}");
            singleLinked.Insert(5, 10);
            Console.WriteLine($"单链表插入索引为5的值为10");
            for (int i = 0; i < singleLinked.Count; i++)
            {
                Console.WriteLine($"单链表查找索引为:{i}值为:{singleLinked[i]}");
            }
        }
    }
}
