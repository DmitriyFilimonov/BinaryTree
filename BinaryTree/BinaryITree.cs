using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class BinaryITree : ITree
    {
        Node _root;
        public BinaryITree()
        {

        }
        private StringBuilder AddToString(Node node, StringBuilder stringBuilder)
        {
            if (node==null)
            {
                return stringBuilder;
            }
            AddToString(node.Left, stringBuilder);
            stringBuilder.Append(node.Value);
            AddToString(node.Right, stringBuilder);

            return stringBuilder;
        }
        public string Print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder = AddToString(_root, stringBuilder);
            return stringBuilder.ToString();
        }
        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                return;
            }
            Add(value, _root);
        }
        private Node Add(int value, Node currentNode)
        {
            if (currentNode==null)
            {
                currentNode = new Node(value);
                return currentNode;
            }

            if (value < currentNode.Value)
            {
                currentNode.Left = Add(value, currentNode.Left);
            }

            if (value > currentNode.Value)
            {
                currentNode.Right = Add(value, currentNode.Right);
            }

            if (value==currentNode.Value)
            {
                currentNode.Count++;
            }

            return currentNode;
        }

        public void CountAllAndSum()
        {
            throw new NotImplementedException();
        }

        public void DeleteOneByValue(int value)
        {
            DeleteOneByValue(value, _root);
        }
        private Node DeleteOneByValue(int value, Node currentNode)
        {
            if (currentNode == null)
            {
                return currentNode;
            }

            if (value == currentNode.Value)
            {
                if ()
                currentNode = currentNode.Right;
                return currentNode;
            }
            
            if (value>currentNode.Value)
            {
                currentNode.Right = DeleteOneByValue(value, currentNode.Right);
            }
           
            return currentNode;
        }

        public void GetElementByValue(int value)
        {
            throw new NotImplementedException();
        }

        public void GetFirstWhereMaxCount()
        {
            throw new NotImplementedException();
        }

        public void GetFirstWhereMinCount()
        {
            throw new NotImplementedException();
        }

        public void GetMax()
        {
            throw new NotImplementedException();
        }

        public void GetMin()
        {
            throw new NotImplementedException();
        }


        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
