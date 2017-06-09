using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = new List<int>(){66,44,22,88,55,99,77,11,33,48};
            MyTreeNode<int> root = NodeController<int>.CrateBinarySearchTree(elements);

            List<string> strElements = new List<string>(){"Foo","Afc","Beyond","Tarmar","Coug","Jerk","Hour","Ade"};
            MyTreeNode<string> strRoot = NodeController<string>.CrateBinarySearchTree(strElements);

            List<int> norElements = new List<int>() { 66,44,88,22,55,77,99,11,33,48,56};
            MyTreeNode<int> norRoot = NodeController<int>.CreateNormalTree(norElements);

            bool ret = NodeController<int>.IsBinarySearchTree(root);
            bool norRet = NodeController<int>.IsBinarySearchTree(norRoot);

            root.LNode.RNode.Value = 45;
            ret = NodeController<int>.IsBinarySearchTree(root);
        }
    }
}
