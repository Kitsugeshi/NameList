using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameList
{
    class List<T> : IEnumerable<T>
    {
        Node<T>? head; 
        Node<T>? tail; 
        int count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail!.Next = node;
            tail = node;

            count++;
        }

        public bool Remove(T data)
        {
            Node<T>? current = head;
            Node<T>? previous = null;

            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head?.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Contains(T data)
        {
            int n = 0;
            Node<T>? current = head;
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data))
                {
                    Console.WriteLine(data);
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine(0);
        }
        public int Count { get { return count; } }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T>? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
