using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_LinkedList
{
    internal class Node
    {
        public string Name { get; set; }
        public Node Next;

        public Node(string name)
        {
            Name = name;
        }
    }
}
