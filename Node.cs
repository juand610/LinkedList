using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsList.Logic
{
    public class Node<T>
    {
        public Node<T>? Previous { get; set; }

        public Node<T>? Next { get; set; }

        public T Date { get; set; }

        public Node(T data)
        {
            Previous = null;
            Date = data;
            Next = null;
        }
    }
}
