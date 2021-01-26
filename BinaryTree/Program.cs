using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryITree tree = new BinaryITree();
            tree.Add(7);
            tree.Add(9);
            tree.Add(8);
            tree.Add(11);
            tree.Add(10);
            tree.Add(13);
            tree.Add(6);

            //var root = new Node(5);
            //root.Right = new Node(6);
            //root.Right.Right = new Node(7);

            //var tmpNode = root.Right.Right;
            //tmpNode = null;

            tree.DeleteOneByValue(9);
        }
    }
}
