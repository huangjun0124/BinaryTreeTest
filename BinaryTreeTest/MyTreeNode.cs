using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeTest
{
    class MyTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public MyTreeNode<T> LNode { get; set; }

        public MyTreeNode<T> RNode { get; set; }

        public MyTreeNode(T element)
        {
            Value = element;
            LNode = null;
            RNode = null;
        }
    }


}
