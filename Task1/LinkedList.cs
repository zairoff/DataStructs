using System;

namespace Task1
{
    public class LinkedList<T>
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

        public void Add(T item)
        {
            var node = new Node<T>(item);

            if (_first == null)
                _first = _last = node;
            else
            {
                _last._next = node;
                _last = node;
            }

        }

    }
}
