using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeTest
{
    class NodeController<T> where T : IComparable<T>
    {
        public static MyTreeNode<T> CrateBinarySearchTree(List<T> elements)
        {
            if (elements.Count == 0) return null;
            MyTreeNode<T> root = new MyTreeNode<T>(elements[0]);

            for (int i = 1; i < elements.Count; i++)
            {
                InsertNode(root, elements[i]);
            }
            return root;
        }

        private static bool InsertNode(MyTreeNode<T> curNode, T element)
        {
            if (curNode.Value.CompareTo(element) > 0)
            {
                if (curNode.LNode == null)
                {
                    curNode.LNode = new MyTreeNode<T>(element);
                    return true;
                }
                return InsertNode(curNode.LNode, element);
            }
            else
            {
                if (curNode.RNode == null)
                {
                    curNode.RNode = new MyTreeNode<T>(element);
                    return true;
                }
                return InsertNode(curNode.RNode, element);
            }
        }

        public static MyTreeNode<T> CreateNormalTree(List<T> elements)
        {
            if (elements.Count == 0) return null;
            int elementCount = elements.Count;
            int stopIndex = (elementCount + 1) / 2;
            MyTreeNode<T>[] listNodes = new MyTreeNode<T>[elementCount];
            listNodes[0]  = new MyTreeNode<T>(elements[0]);
            for (int i = 0; i < stopIndex; i++)
            {
                MyTreeNode<T> node = listNodes[i];
                int lIndex = 2*i + 1;
                if (lIndex < elementCount)
                {
                    MyTreeNode<T> lNode = new MyTreeNode<T>(elements[lIndex]);
                    node.LNode = lNode;
                    listNodes[lIndex] = lNode;
                }
                int rIndex = 2*(i + 1);
                if (rIndex < elementCount)
                {
                    MyTreeNode<T> rNode = new MyTreeNode<T>(elements[rIndex]);
                    node.RNode = rNode;
                    listNodes[rIndex] = rNode;
                }
            }
            return listNodes[0];
        }

        public static bool IsBinarySearchTree(MyTreeNode<T> root)
        {
            if (root == null) return false;
            if (root.LNode == null && root.RNode == null) return true;
            if(root.LNode != null && root.RNode != null)
            {
                if (root.Value.CompareTo(root.LNode.Value) >= 0 && root.Value.CompareTo(root.RNode.Value) <= 0)
                {
                    return IsBinarySearchTree(root.LNode) && IsBinarySearchTree(root.RNode);
                }
                return false;
            }
            if (root.LNode != null)
            {
                if (root.Value.CompareTo(root.LNode.Value) < 0) return false;
                return IsBinarySearchTree(root.LNode);
            }
            if (root.RNode != null)
            {
                if (root.Value.CompareTo(root.RNode.Value) > 0) return false;
                return IsBinarySearchTree(root.RNode);
            }
        }
    }
}
