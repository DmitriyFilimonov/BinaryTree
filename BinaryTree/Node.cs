using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public int Count { get; set; }
        public Node ()
        {
            Count = 0;
        }
        public Node(int value)
        {
            Value = value;
            Count = 1;
        }
    }
}
