using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_LinkedList
{
    internal class LinkedList
    {
        private Node _head;
        public void Add(string name)
        {
            Node NewNode = new Node(name);
            if(_head == null || string.Compare(name, _head.Name) <= 0)
            {
                NewNode.Next = _head;
                _head = NewNode;
            }
            else
            {
                Node current = _head;
                while (current.Next != null && string.Compare(name, current.Next.Name) > 0)
                {
                    current = current.Next;
                }
                NewNode.Next = current.Next;
                current.Next = NewNode;
            }
            
        }
        public Node Contains(string name)
        {
            Node current = _head;
            if(current.Name == name)
            {
                return current;
            }
            while(current.Next != null)
            {
                current = current.Next;
                if(current.Name == name)
                {
                    return current;
                }
            }
            return null;
        }
        public bool Remove(string name)
        {
            if(_head == null)
            {
                return false;
            }
            if(_head.Name == name)
            {
                _head = _head.Next;
                return true;
            }
            Node current = _head;
            while (current.Next != null)
            {
                if(current.Next.Name == name)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Print()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Name);
                current = current.Next;
            }
        }
    }
}
