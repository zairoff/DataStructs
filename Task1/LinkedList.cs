using System;

namespace Task1
{
    public class LinkedList<T> where T : IComparable
    {
        private class Node<T>
        {
            public T _data;
            public Node<T> _next;

            public Node(T data)
            {
                _data = data;
            }
        }

        private Node<T> _first;
        private Node<T> _last;
        private int _count;

        public void Add(T item)
        {
            var node = new Node<T>(item);

            if (IsEmpty())
                _first = _last = node;
            else
            {
                _last._next = node;
                _last = node;
            }

            _count++;
        }

        public int Length()
        {
            return _count;
        }

        private bool IsEmpty()
        {
            return _first == null;
        }

        public void Print()
        {
            var runner = _first;
            while(runner != null)
            {
                Console.WriteLine(runner._data);
                runner = runner._next;
            }
        }

        public void AddAt(int index, T item)
        {
            if (index > _count)
                throw new IndexOutOfRangeException();

            var node = new Node<T>(item);

            if (IsEmpty())
            {
                _first = _last = node;
                _count++;
                return;
            }

            // check if insertion to the beginning
            if(index == 0)
            {
                node._next = _first;
                _first = node;
                _count++;
                return;
            }

            // check if insertion to the end
            if(index == _count)
            {
                _last._next = node;
                _last = node;
                _count++;
                return;
            }

            var runner = _first;
            while (--index > 0)
                runner = runner._next;

            node._next = runner._next;
            runner._next = node;
            _count++;
        }

        public void Remove(T item) 
        {
            var previous = _first;
            var runner = _first;

            while(runner != null)
            {
                if (item.CompareTo(runner._data) == 0)
                {
                    previous._next = runner._next;
                    break;
                }

                previous = runner;
                runner = runner._next;
            }            
        }
    }
}
