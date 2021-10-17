using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueActivity
{
    public class Stack<T> //LIFO
    {
        private cNode<T> head;
        private cNode<T> tail;
        private int size;
        private string traversal;

        public class cNode<R>
        {
            public cNode<R> next;
            public cNode<R> previous;
            public R data;

            public cNode(R data)
            {
                this.next = null;
                this.previous = null;
                this.data = data;
            }
        }

        public Stack()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T Peek() //Was get last
        {
            return tail.data;
        }

        /*public void Append(T t)
        {
            cNode<T> node = new cNode<T>(t);

            if (IsEmpty())
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
                tail = node;
                tail.next = head;
                head.previous = tail;
            }
            size++;
        }*/

        public void Push(T data) //add to tail
        {
            cNode<T> node = new cNode<T>(data);

            if (IsEmpty())
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                node.previous = tail;
                tail = node;
            }
            size++;
        }

        public T Pop()
        {
            T data;

            if (tail == null)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                data = tail.data; //get tail
                tail = tail.previous;
                tail.next = null; //delete the tail
                size--;                
            }
            return data;
        }

        public string Traverse()
        {
            traversal = null;
            TraverseList(head);
            return traversal;
        }

        public void TraverseList(cNode<T> node)
        {
            if (node.next == null)
            {
                traversal += node.data + Environment.NewLine;
                return;
            }
            else
            {
                traversal += node.data + Environment.NewLine;
                TraverseList(node.next);
            }
        }
    }
}
