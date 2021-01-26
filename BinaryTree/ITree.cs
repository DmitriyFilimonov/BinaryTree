using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public interface ITree
    {
        string Print();
        void Add(int value);
        void DeleteOneByValue(int value);
        void Read();
        void GetElementByValue(int value);
        void GetMax();
        void GetMin();
        void GetFirstWhereMaxCount();
        void GetFirstWhereMinCount();
        void CountAllAndSum();
    }
}
