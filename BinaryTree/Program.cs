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

            tree.DeleteOneByValue(10);
        }
    }
}
