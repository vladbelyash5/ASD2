﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Tree<T>
        where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }

        public int Count { get; private set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public List<T> Preorder() // префиксный обход
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }
                
                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
            }
            return list;
        }



        public List<T> Postorder() // постфиксный обход
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return Postorder(Root);
        }
        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if(node != null)
            {
                

                if (node.Left != null)
                {
                    list.AddRange(Postorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Postorder(node.Right));
                }

                list.Add(node.Data);
            }
            return list;
        }
        
        public List<T> Inorder() //инфиксный обход = соритировка
        {
            if (Root == null)
            {
                return new List<T>();
            }
            return Inorder(Root);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange (Inorder(node.Right));
                }
            }
            return list;
        }
    }
}
