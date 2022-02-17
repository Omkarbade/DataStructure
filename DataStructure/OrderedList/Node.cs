using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.OrderedList
{
    public class Node<T>
    { 
        // Variable 

        public T data;
        public Node<T> next;
     
        /// data intialization
        
        public Node(T value)
        {
            this.data = value;
            this.next = null;
        }
    }
}
