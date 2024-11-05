using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


            public class Node<T>
        {
            public T Data;
            public Node<T> Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class LinkedList<T>
        {
            private Node<T> head;

            public LinkedList()
            {
                head = null;
            }

            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }

            public void AddLast(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> present = head;
                    while (present.Next != null)
                    {
                        present = present.Next;
                    }
                    present.Next = newNode;
                }
            }
            public void AddAtPosition(int position, T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (position <= 1)
                {
                    AddAtPosition(position, data);
                    return;
                }

                Node<T> present = head;
                int presentPosition = 1;
                while (present != null && presentPosition < position - 1)
                {
                    present = present.Next;
                    presentPosition++;
                }
                if (present == null)
                {
                    Console.WriteLine("Position out of bounds");
                    return;
                }

                newNode.Next = present.Next;
                present.Next = newNode;
            }

            public void DeleteFirst()
            {
                if (head != null)
                {
                    head = head.Next;
                }
            }

            public void DeleteLast()
            {
                if (head == null || head.Next == null)
                {
                    head = null;
                }
                else
                {
                    Node<T> present = head;
                    while (present.Next.Next != null)
                    {
                        present = present.Next;
                    }
                    present.Next = null;
                }
            }


            public void PrintList()
            {
                Node<T> present = head;
                while (present != null)
                {
                    Console.Write(present.Data + "_");
                    present = present.Next;
                }
                Console.WriteLine();
            }
        }

            static void Main()
            {
                LinkedList<int> linkedList = new LinkedList<int>();

                // إضافة عناصر للائحة المترابطة
                linkedList.AddFirst(3);
                linkedList.AddFirst(2);
                linkedList.AddFirst(1);

                Console.WriteLine("Linked list after adding elements at the beginning:");//القائمة بعد اضافة عناصر البداية 
                linkedList.PrintList();

                linkedList.AddLast(4);
                linkedList.AddLast(5);

                Console.WriteLine("Linked list after adding elements at the end:");//القائمة بعد إضافة عناصر النهاية
                linkedList.PrintList();

                linkedList.AddAtPosition(2, 2);

                Console.WriteLine("linked list after adding elements at the middle: ");//اضافة في المنتصف
                linkedList.PrintList();


                linkedList.DeleteFirst();

                Console.WriteLine("Linked list after removing element from the beginning:");//القائمة بعد إزالة  عنصر من البداية
                linkedList.PrintList();

                linkedList.DeleteLast();

                Console.WriteLine("Linked list after removing element from the end:");// القائمة بعد إزالة  عنصر من النهاية
                linkedList.PrintList();

            }
        }
    }


