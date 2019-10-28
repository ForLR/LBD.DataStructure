using System;
using System.Collections.Generic;
using System.Text;

namespace LBD.Tree
{
    /// <summary>
    /// 二叉树
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T>
    {

        public Node<T> Root { get; set; }

        public BinaryTree()
        {

        }
        public BinaryTree(T data)
        {
            this.Root = new Node<T>(data);
        }

        /// <summary>
        /// node 节点下面插入左孩子节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="data"></param>
        public void InsertLeft(Node<T> node,T data)
        {
            Node<T> tempNode = new Node<T>(data);
            tempNode.LeftChild = node.LeftChild;
            node.LeftChild = tempNode;
        }

        public void InsertRight(Node<T> node, T data)
        {
            Node<T> tempNode = new Node<T>(data);
            tempNode.RightChild = node.RightChild;
            node.RightChild = tempNode;
        }
        /// <summary>
        /// 移除node节点下面的左节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>

        public Node<T> RemoveLeft(Node<T> node)
        {
            if (node==null||node.LeftChild==null)
            {
                return null;
            }
            var result = node.LeftChild;
            node.LeftChild = null;
            return result;
        }

        public Node<T> RemoveRight(Node<T> node)
        {
            if (node == null || node.RightChild == null)
            {
                return null;
            }
            var result = node.RightChild;
            node.RightChild = null;
            return result;
        }
        /// <summary>
        /// node是否为叶子节点  是否还有子节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool IsLeafNode(Node<T> node)
        {
            if (node==null)
            {
                return false;
            }
            return node.LeftChild == null && node.RightChild == null;
        }


        /// <summary>
        /// 二叉树深度
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int GetDepth(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftDepth = GetDepth(root.LeftChild);
            int rightDepth = GetDepth(root.RightChild);
            if (leftDepth>rightDepth)
            {
                return leftDepth + 1;
            }
            else
            {
                return rightDepth + 1;
            }
        }
        #region 递归遍历二叉树
        /// <summary>
        /// 前序
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(Node<T> node)
        {
            if (node!=null)
            {
                ///根 左 右
                Console.WriteLine(node.Data);

                PreOrder(node.LeftChild);

                PreOrder(node.RightChild);
            }
        }

        /// <summary>
        /// 中序
        /// </summary>
        /// <param name="node"></param>
        public void MidOrder(Node<T> node)
        {
            if (node != null)
            {
                ///左 根  右
                MidOrder(node.LeftChild);

                Console.WriteLine(node.Data);

                MidOrder(node.RightChild);
            }
        }
        public void PostOrder(Node<T> node)
        {
            if (node!=null)
            {
                //左 右 根
                PostOrder(node.LeftChild);

                PostOrder(node.RightChild);

                Console.WriteLine(node.Data);
            }
        }
        #endregion

        # region 非递归遍历二叉树




        #endregion


    }
}
