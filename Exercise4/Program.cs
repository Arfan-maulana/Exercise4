using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        class node
        {

            public int info;
            public node next;
            public node(int i, node n)
            {
                info = i;
                next = n;
            }
        }
        class Stack
        {
            node top;
            public Stack()
            {
                top = null;
            }

            bool empty()
            {
                if (top == null)
                    return (true);
                else
                    return (false);

            }

            public void push(int element)
        {

            node fan;
            fan = new node(element, null);
            fan.next = top;
            top = fan;
            Console.WriteLine("\n" + element + "pushed");
        }

        static void Main(string[] args)
            {
            }
        }
    }
}
