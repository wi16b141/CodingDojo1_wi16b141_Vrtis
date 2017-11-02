using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_wi16b141.Stack
{
    class StackElement<T>
    {
        public T Value { get; set; }
        public StackElement<T> Next { get; set; }
    }
}
