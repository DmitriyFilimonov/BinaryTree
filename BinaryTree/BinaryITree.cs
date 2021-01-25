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
                _root = new Node();
                _root.Value = value;
                return;
            }
            Add(value, _root);
            return;
        }
        private void Add(int value, Node currentNode)
        {
            
            if (currentNode == null)
            {
                
                currentNode.Value = value;
                currentNode.Count++;
                return;
            }
            if (value < currentNode.Value)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new Node();
                    currentNode = currentNode.Left;
                    currentNode.Value = value;
                    currentNode.Count++;
                    return;
                }
                Add(value, currentNode.Left);
            }
            if (value > currentNode.Value)
            {
                if (currentNode.Right==null)
                {
                    currentNode.Right = new Node();
                    currentNode = currentNode.Right;
                    currentNode.Value = value;
                    currentNode.Count++;
                    return;
                }
                Add(value, currentNode.Right);
            }
            return;
        }

        public void CountAllAndSum()
        {
            throw new NotImplementedException();
        }

        public void Delete(int value)
        {
            throw new NotImplementedException();
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
