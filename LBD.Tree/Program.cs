using System;

namespace LBD.Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeDemo();

            Console.ReadKey();
        }

        public static void BinaryTreeDemo()
        {
            BinaryTree<string> binaryTree = new BinaryTree<string>("A");
            Node<string> rootNode = binaryTree.Root;

            binaryTree.InsertLeft(rootNode, "B");
            binaryTree.InsertRight(rootNode, "C");

            Node<string> nodeB = rootNode.LeftChild;

            binaryTree.InsertLeft(nodeB, "D");
            binaryTree.InsertRight(nodeB, "E");

            Node<string> nodeC = rootNode.RightChild;

            binaryTree.InsertRight(nodeC, "F");

            Console.WriteLine("二叉树深度"+ binaryTree.GetDepth(binaryTree.Root));

            Console.WriteLine("前序遍历二叉树");
            binaryTree.PreOrder(rootNode);
            Console.WriteLine("中序遍历二叉树");
            binaryTree.MidOrder(rootNode);
            Console.WriteLine("后序遍历二叉树");
            binaryTree.PostOrder(rootNode);




        }
    }
}
