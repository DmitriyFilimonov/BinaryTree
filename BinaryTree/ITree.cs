using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public interface ITree
    {
        void Add(int value);
        void Delete(int value);
        void Read();
        void GetElementByValue(int value);
        void GetMax();
        void GetMin();
        void GetFirstWhereMaxCount();
        void GetFirstWhereMinCount();
        void CountAllAndSum();
    }
}
