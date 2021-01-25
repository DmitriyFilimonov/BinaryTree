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
                _root.Count++;
                return;
            }
            if (value < _root.Value)
            {
                if (_root.Left == null)
                {
                    _root.Left = new Node(value);
                    return;
                }
                Add(value, _root.Left);
            }
            if (value > _root.Value)
            {
                if (_root.Right == null)
                {
                    _root.Right = new Node(value);
                    return;
                }
                Add(value, _root.Right);
            }
            return;
        }
        private void Add(int value, Node currentNode)
        {
            if (value == currentNode.Value)
            {
                currentNode.Count++;
                return;
            }
            if (value < currentNode.Value)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new Node(value);
                    return;
                }
                if (value > currentNode.Left.Value)
                {
                    currentNode.Right = new Node(currentNode.Value, currentNode.Count);
                    currentNode.Value = value;
                    return;
                }
                Add(value, currentNode.Left);
            }
            if (value > currentNode.Value)
            {
                if (currentNode.Right==null)
                {
                    currentNode.Right = new Node(value);
                    return;
                }
                if (value > currentNode.Right.Value)
                {
                    currentNode.Left = new Node(currentNode.Value, currentNode.Count);
                    currentNode.Value = value;
                }
                Add(value, currentNode.Right);
            }
            return;
        }

        public void CountAllAndSum()
        {
            throw new NotImplementedException();
        }

        public void DeleteOnByValue(int value)
        {
            ;
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
