using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures.L2LinkedList
{
    public class L2Node
    {
        public int Value { get; set; }
        public L2Node Previous { get; set; }
        public L2Node Next { get; set; }
        public L2Node(int _value)
        {
            Value = _value;
            Next = null;
            Previous = null;
        }
    }
}
