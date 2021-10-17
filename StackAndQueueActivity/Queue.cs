using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueActivity
{
    public class Queue<T> //FIFO
    {
        private cNode<T> head;
        private cNode<T> tail;
        //private cNode<T> current;
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

        public Queue()
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

        public T Peek() //gets front of queue
        {
            return head.data;
        }

        public void Enqueue(T data) //appends node to queue
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

        public T Dequeue() //removes front fo queue
        {
            T data;

            if (tail == null)
            {
                throw new Exception("Queue is empty");
            }
            else
            {
                data = head.data;
                head = head.next;
                head.previous = null;
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
