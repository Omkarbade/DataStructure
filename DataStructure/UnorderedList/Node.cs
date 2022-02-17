using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.UnorderedList
{
    public class Node<T>
    {
        //Variables.

        public T data;
        public Node<T> next;
  
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
       
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
