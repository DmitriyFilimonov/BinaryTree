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
        private Node DeleteOneByValue(int value, Node subRoot)
        {
            if (subRoot == null)
            {
                return subRoot;
            }
            if (value == subRoot.Value)
            {
                Node tmp;
                if (subRoot.Right == null)
                    tmp = subRoot.Left;
                else
                {
                    Node ptr = subRoot.Right;
                    if (ptr.Left == null)
                    {
                        ptr.Left = subRoot.Left;
                        tmp = ptr;
                    }
                    else
                    {
                        Node pmin = ptr.Left;
                        while (pmin.Left != null)
                        {
                            ptr = pmin;
                            pmin = ptr.Left;
                        }
                        ptr.Left = pmin.Right;
                        pmin.Left = subRoot.Left;
                        pmin.Right = subRoot.Right;
                        tmp = pmin;
                    }
                }
                subRoot = null;
                return tmp;
            }
            else if (value < subRoot.Value)
                subRoot.Left = DeleteOneByValue(value, subRoot.Left);
            else
                subRoot.Right = DeleteOneByValue(value, subRoot.Right);
            return subRoot;
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

        public int GetMaxValue()
        {
            Node maxNode = GetMaxNode(_root);
            return maxNode.Value;
        }
        private Node GetMaxNode(Node maxNode)
        {
            
            if (maxNode.Right!=null)
            {
                maxNode = GetMaxNode(maxNode.Right);
            }

            return maxNode;
        }

        public int GetMinValue()
        {
            Node minNode = GetMinNode(_root);
            return minNode.Value;
        }
        private Node GetMinNode(Node minNode)
        {

            if (minNode.Left != null)
            {
                minNode = GetMinNode(minNode.Left);
            }

            return minNode;
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
