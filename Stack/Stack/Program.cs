using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <string> myStack = new Stack<string>();
            myStack.Push("Edgaras");
            myStack.Push("Test");
            myStack.Push("foo");
            myStack.Push("bar");

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
        }
    }
}
