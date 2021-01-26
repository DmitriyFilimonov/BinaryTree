using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryITree tree = new BinaryITree();
            tree.Add(4);
            tree.Add(45);
            tree.Add(0);
            tree.Add(7);
            tree.Add(3);
            tree.Add(-5);
            tree.Add(-5);
            tree.Add(5);
            tree.Add(-5);
            tree.Add(0);
            tree.Add(7);
            tree.Add(12);
            tree.Add(10);
            tree.Add(8);
            tree.Add(6);

            tree.DeleteOneByValue(45);
        }
    }
}
