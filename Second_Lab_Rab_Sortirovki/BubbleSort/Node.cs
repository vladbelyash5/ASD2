using System;

namespace BubbleSort
{
    class Node<T> : IComparable<T>, IComparable
        where T : IComparable, IComparable<T>  
    {
        public T Data { get; private set; }

        public Node<T> Left { get; private set; } // поддерево

        public Node<T> Right { get; private set; } // второе поддерево

        
        public Node(T data) // конструктор 
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right) // второй конструктор
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if(node.Data.CompareTo(Data) == -1)
            {
                if(Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public int CompareTo(object obj)
        {
            if(obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Не совпадение типов");
            }
        }
        public int CompareTo(T other)
        {
            return Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
