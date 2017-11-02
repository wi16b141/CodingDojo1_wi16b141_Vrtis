using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1_wi16b141.Stack
{
    class Stack<T>
    {
        //Variablen
        private StackElement<T> currentElement; //stores the latest item of the Stack

        //Methoden
        public void Push(T item)
        {
            if (currentElement == null)
            {
                currentElement = new StackElement<T>() { Value = item, Next = null }; //using object initializer
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { Value = item, Next = currentElement };
                currentElement = temp;
            }
        }

        public T Pop()
        {
            if (currentElement == null)
            {
                throw new NullReferenceException(); //reference is not initialized 
            }
            else
            {
                StackElement<T> temp = new StackElement<T> { Value = currentElement.Value, Next = currentElement.Next };
                currentElement = currentElement.Next;
                return temp.Value;
            }
        }

        public T Peek()
        {
            if (currentElement == null)
            {
                throw new InvalidOperationException();
                //return default(T); //returns the default value (value-types: 0, reference-types: null)
                
            }
            else
            {
                return currentElement.Value;
            }
        }
    }
}
