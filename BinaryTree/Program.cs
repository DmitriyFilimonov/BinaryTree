using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryITree tree = new BinaryITree();
            tree.Add(4);
            tree.Add(6);
            tree.Add(0);
            tree.Add(7);
            tree.Add(3);
            tree.Add(-5);
            tree.Add(-5);
            tree.Add(5);
            tree.Add(-5);
            tree.Add(0);
            tree.Add(7);
        }
    }
}
