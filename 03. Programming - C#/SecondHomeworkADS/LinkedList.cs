using System;
using System.Collections.Generic;
using System.Text;

namespace SecondHomeworkADS
{
    internal class LinkedListNode
    {

        private int valueHolder;

        public int ValueHolder
        {
            get { return valueHolder; }
            set { valueHolder = value; }
        }

        private LinkedListNode previous;

        public LinkedListNode Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        private LinkedListNode next;

        public LinkedListNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public LinkedListNode(int value)
        {
            valueHolder = value;
            previous = null;
            next = null;
        }

    }
    class DoublyLinkedList
    {
        private int size;
        private LinkedListNode head;
        private LinkedListNode tail;

        public DoublyLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }

        public void Add(int value)
        {
            AddLast(value);
        }

        public void AddFirst(int value)
        {
            if (head == null)
            {
                head = new LinkedListNode(value);
                tail = head;
            }
            else
            {
                LinkedListNode newNode = new LinkedListNode(value);
                head.Previous = newNode;
                newNode.Next = head;
                head = newNode;
            }
            size++;
        }

        public void PushAt(int newElement, int position)
        {
            LinkedListNode newNode = new LinkedListNode(newElement);
            newNode.Next = null;
            newNode.Previous = null;
            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
                
            }
            else
            {
                LinkedListNode temp = new LinkedListNode(newElement);
                temp = head;
                for (int i = 1; i < position-1 ; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                        
                    }
                }
                if (temp != null)
                {
                    newNode.Next = temp.Next;
                    newNode.Previous = temp;
                    temp.Next = newNode;
                    size++;
                    if (newNode.Next != null)
                        newNode.Next.Previous = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List Exception");
            }
            LinkedListNode nodeToRemove = head;
            head = head.Next;
            nodeToRemove.Next = null;
            if (head != null)
            {
                head.Previous = null;
            }
            size--;
            return nodeToRemove.ValueHolder;
        }

        public int GetFirst()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List Exception");
            }
            return head.ValueHolder;
        }

        public void AddLast(int value)
        {
            if (tail == null)
            {
                tail = new LinkedListNode(value);
                head = tail;
            }
            else
            {
                LinkedListNode newNode = new LinkedListNode(value);
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            size++;
        }

        

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List Exception");
            }
            LinkedListNode nodeToRemove = tail;
            tail = tail.Previous;
            nodeToRemove.Previous = null;
            if (tail != null)
            {
                tail.Next = null;
            }
            size--;
            return nodeToRemove.ValueHolder;
        }

        public int GetLast()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List Exception");
            }
            return tail.ValueHolder;
        }

        public int FindElement(int value)
        {
            LinkedListNode current = head;
            for (int i = 0; i < size; i++)
            {
                if (current.ValueHolder ==value)
                {
                    return i+1;
                }
                else
                {
                    current=current.Next;
                }
            }
            return -1;
        }

        public bool Contains(int value)
        {
            if (IsEmpty())
            {
                throw new Exception("Empty List Exception");
            }

            LinkedListNode first = head;
            LinkedListNode last = tail;

            if (first == last)
            {
                return first.ValueHolder == value;
            }

            while (first != last)
            {
                if (first.ValueHolder == value || last.ValueHolder == value)
                {
                    return true;
                }
                first = first.Next;
                last = last.Previous;
            }
            return false;
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int GetElementByIndex(int index)
        {
            LinkedListNode current = head;
            int count = 0; 
            while (current != null)
            {
                if (count == index)
                    return current.ValueHolder;
                count++;
                current = current.Next;
            }

            return -1;
        }

        public void Print()
        {
            LinkedListNode current = head;

            int[] linkedListValues = new int[size];
            
            for (int i = 0; i < linkedListValues.Length; i++)
            {
                if(current != null){
                linkedListValues[i] = current.ValueHolder;
                current = current.Next;
            }
            }
            foreach(var t in linkedListValues)
            {
                Console.WriteLine(t);
            }
            
        }

    }
}
