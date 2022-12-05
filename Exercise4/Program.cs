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
            private int[] ele;
            private int top;
            private int max;
            public Stack(int size)
            {
                ele = new int[size];
                top = -1;
                max = size;
            }


            static void Main(string[] args)
            {
            }
        }
    }
}
