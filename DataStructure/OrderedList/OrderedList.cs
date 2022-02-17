using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.OrderedList
{
    public class OrderedList<T> where T : IComparable
    {
        public Node<T> head;
        /// <summary>
        /// add the element at first position
        /// </summary>
        public void AddFirst(Node<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        
        /// add the number into list.
      
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if (head == null)
            {
                AddFirst(node);
            }
            else if (head.data.CompareTo(value) >= 0)
            {
                AddFirst(node);
            }
            else
            {
                Node<T> temp = head;
                Node<T> prev = head;
                while (temp.next != null && temp.next.data.CompareTo(value) < 0)
                {
                    temp = temp.next;
                }
                if (temp.next == null)
                {
                    temp.next = node;
                }
                else if (temp.next.data.CompareTo(value) > 0)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
            }
        }
        
        /// search the number.
        
        public bool Search(T value)
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null && !(temp.data.Equals(value)))
                {
                    temp = temp.next;
                }
                if (temp.data.Equals(value))
                {
                    return true;
                }
                return false;
            }
        }
        
        /// popout the number
       
        public void Pop(T value)
        {
            if (head == null)
            {
                Console.WriteLine("Data not found");
            }
            else if (head.data.Equals(value))
            {
                head = head.next;
            }
            else
            {
                Node<T> prev = head;
                Node<T> temp = head;

                while (temp != null && !(temp.data.Equals(value)))
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp.data.Equals(value))
                {
                    prev.next = temp.next;
                    temp.next = null;
                }
            }
        }
        
        /// display the words of linkedlist
        public string Display()
        {
            Node<T> temp = head;
            string data = "";
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    data = data + temp.data + " ";
                    temp = temp.next;
                }
                data += temp.data;
            }
            Console.WriteLine();
            return data;
        }
    }
}
