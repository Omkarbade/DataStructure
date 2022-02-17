using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.UnorderedList
{
     public class LinkedList<T>
    {
        private Node<T> head;
        /// <summary>
        /// add the words
        /// </summary>
        
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            //// iterate till the last element and make next field of last element as newNode.
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        
        /// search word from linked list.
       
        public int Search(T value)
        {
            Node<T> root = this.head;
            int count = 0;
            while (root != null)
            {
                if (root.data.Equals(value))
                {
                    return count;
                }
                root = root.next;
                count++;
            }
            return count;
        }
       
        /// remove the first element from linkedlist.
        
        public void RemoveElement(T value)
        {
            if (head == null)
            {
                Console.WriteLine("No element to delete");
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
        
        /// Get Size of Linked List
       
        public int Size()
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                Node<T> temp = head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
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
