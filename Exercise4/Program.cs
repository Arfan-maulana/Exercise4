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
                int stack = [41];
                int top;
                top = -1;
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
            public void pop()
            {
                Console.WriteLine("\nThe poped element is :" + top.info);
                top = top.next; // make top point to the next node is squence
            }
            public void display()
            {
                node tmp;
                if (empty())
                    Console.WriteLine("\nStack Empty");
                else
                {
                    for (tmp = top; tmp != null; tmp = tmp.next)
                    {
                        Console.WriteLine(top.info);
                    }
                }
            }

            static void Main(string[] args)
            {
                Stack s = new Stack();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("***Stack Menu***\n");
                    Console.WriteLine("1. Push");
                    Console.WriteLine("2. pop ");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. exit");
                    Console.WriteLine("\nEnter your choice");
                    string input = Console.ReadLine();
                    char ch = Convert.ToChar(input == "" ? "0" : input);
                    switch (ch)
                    {
                        case '1':
                            Console.WriteLine("\nEnter a number : ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            s.push(num);
                            break;
                        case '2':
                            if (s.empty())
                            {
                                Console.WriteLine("\nStack empty");
                                break;
                            }
                            s.pop();
                            break;
                        case '3':
                            s.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("\nInvalid Choice");
                            break;
                    }
                }
            }
        }
    } }