using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace datastructures.LinkedList
{
    public class LinkedList:IDataStructures1
    {
        private Node root;
        private int length;


        public LinkedList()
        {
            root = null;
            length = 0;
        }
        public LinkedList(int a)
        {
            root = new Node(a);
            length = 1;
        }
        public LinkedList(int[] a)
        {
            if (a.Length != 0)
            {
                root = null;
                length = 0;
                AddToEnd(a);
            }


        }

        public void AddToEnd(int a) //добавление в конец 1 элемента 
        {
            if (length == 0)
            {
                root = new Node(a);
                length = 1;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                length++;
            }
        }
        public void AddToEnd(int[] a) //добавление в конец N элементов 
        {
            if (a.Length != 0)
            {

                if (length == 0)
                {
                    root = new Node(a[0]);
                    Node tmp = root;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;

                    }
                    length = a.Length;
                }
                else
                {
                    Node tmp = root;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    for (int i = 0; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    length += a.Length;
                }
            }
        }
        public void AddToStart(int a) //добавление в начало 1 элемента 
        {
            if (length == 0)
            {
                root = new Node(a);
                length = 1;
            }
            else
            {
                Node tmp = new Node(a);
                tmp.Next = root;
                root = tmp;
                length++;

            }
        }
        public void AddToStart(int[] a) //добавление в начало N элемента 
        {
            if (a.Length != 0)
            {

                if (length == 0)
                {
                    AddToEnd(a);
                }

                else
                {
                    for (int i = a.Length - 1; i >= 0; i--)
                    {
                        Node tmp = new Node(a[i]);
                        tmp.Next = root;
                        root = tmp;
                        length++;
                    }

                }
            }
        }

        public int[] ReturnArray() //возвращение массива 
        {
            int[] array = new int[length];
            if (length != 0)
            {
                int i = 0;
                Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            return array;
        }
        public void Revers6() //реверс массива 
        {
            if (length != 0)
            {
                Node tmproot = root;
                while (tmproot.Next != null)
                {
                    Node tmp = tmproot.Next;
                    tmproot.Next = tmproot.Next.Next;
                    tmp.Next = root;
                    root = tmp;
                }
            }
        }
        public void IndexAdding(int a, int b)//добавление по индексу 
        {
            if (length != 0)
            {
                if (a == 0)
                {
                    AddToStart(b);
                }
                else if (a == length - 1)
                {
                    AddToEnd(b);
                }
                else
                {
                    Node tmp = root;
                    for (int i = 0; i < a && tmp.Next != null; i++)
                    {
                        tmp = tmp.Next;
                    }
                    Node tmp2 = new Node(b);
                    tmp2.Next = tmp.Next;
                    tmp.Next = tmp2;
                    length++;
                }
            }
            else
            {
                AddToEnd(b);
            }


        }
        public void DeletToEnd()// удаление 1 элеметов с конца
        {
            if (length <= 1)
            {
                root = null;
                length = 0;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = null;
                length--;
            }
        }
        public void DeletToEnd(int a)// удаление N элеметов с конца
        {
            if (a <= length && a >= 0)
            {

                if (length != 0)
                {

                    Node tmp = root;
                    for (int i = length - a; i > 1; i--)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = null;
                    length -= a;
                }
            }
            else
            {
                root = null;
                length = 0;
            }

        }
        public void DeletToStart() // удаление 1 элеметов с начала 
        {
            if (length <= 1)
            {
                root = null;
                length = 0;
            }
            else
            {
                root = root.Next;
                length--;
            }
        }
        public void DeletToStart(int a) // удаление 1 элеметов с начала 
        {
            if (a <= length && a >= 0)
            {

                if (length != 0)
                {
                    for (int i = a; i >= 1; i--)
                    {
                        root = root.Next;
                    }
                    length -= a;
                }
            }
            else
            {
                root = null;
                length = 0;
            }
        }
        public int MinEl1 //минимальный значение элемента в  массиве 
        {
            get
            {
                Node tmp = root;
                Node min = root;
                if (length != 0)
                {
                    for (int i = 1; i < length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value < min.Value)
                        {
                            min = tmp;
                        }
                    }
                    return min.Value;
                }
                else
                {
                    return 0;
                }
            }


        }
        public int MaxEl2 //максимальне значение элемент в  массиве
        {
            get
            {
                Node tmp = root;
                Node max = root;
                if (length != 0)
                {
                    for (int i = 1; i < length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value > max.Value)
                        {
                            max = tmp;
                        }
                    }
                    return max.Value;
                }
                else
                {
                    return 0;
                }
            }

        }
        public int MinIndex3 //индекс минимального значения элемента в массиве 
        {
            get
            {
                Node index = new Node(0);
                Node tmp = root;
                Node min = root;
                if (length != 0)
                {



                    for (int i = 1; i < length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value < min.Value)
                        {
                            min = tmp;
                            index.Value = i;
                        }
                    }
                    return index.Value;
                }
                else
                {
                    return 0;
                }
            }
        }
        public int MaxIndex4 //индекс максимального значения элемента в массиве 
        {
            get
            {
                Node index = new Node(0);
                Node tmp = root;
                Node max = root;
                if (length != 0)
                {



                    for (int i = 1; i < length; i++)
                    {
                        tmp = tmp.Next;
                        if (tmp.Value > max.Value)
                        {
                            max = tmp;
                            index.Value = i;
                        }
                    }
                    return index.Value;
                }
                else
                {
                    return 0;
                }
            }

        }
        public void Bubble9() //значения массива по возвростанию +
        {

            if (length > 1)
            {
                for (int i = 1; i < length; i++)
                {
                    Node tmp = root;
                    if (root.Value > tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        tmp.Next = root;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        Node left = tmp.Next;
                        Node right = tmp.Next.Next;
                        if (left.Value > right.Value)
                        {
                            left.Next = right.Next;
                            right.Next = left;
                            tmp.Next = right;

                        }
                        tmp = tmp.Next;
                    }
                }
            }
        }
        public void Select10() //значения массива по убыванию +
        {
            if (length > 1)
            {
                for (int i = 1; i < length; i++)
                {
                    Node tmp = root;
                    if (root.Value < tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        tmp.Next = root;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        Node left = tmp.Next;
                        Node right = tmp.Next.Next;
                        if (left.Value < right.Value)
                        {
                            left.Next = right.Next;
                            right.Next = left;
                            tmp.Next = right;

                        }
                        tmp = tmp.Next;
                    }
                }
            }
        }

        public void IndexDelet(int a) //удаление по индексу  +
        {
            if (length > 1)
            {
                if (a < length && a != 0)
                {
                    Node tmp = root;
                    for (int i = 1; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = tmp.Next.Next;
                    length--;
                }
                else if (a == 0)
                {
                    DeletToStart();
                }
                else if (a >= length - 1)
                {
                    DeletToEnd();
                }
               
            }
            else
            {
                root = null;
                length = 0;
            }
        }
        public int this[int a] //возвращение значения по индексу +
        {
            get //возвращение значения по индексу
            {
                if (length > 0)
                {
                    Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    return tmp.Value;
                }
                else { return 0; }
            }

            set  //изменение значения по индексу 
            {
                if (a <= length - 1)
                {
                    Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }
            }

        }
        public void DeleteByValue(int a) //удаление по значению +
        {
            if (length != 0)
            {

                Node tmp = root;
                while (tmp.Next.Value != a && tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = tmp.Next.Next;
                length--;
            }
        }
        public int IndexValue(int a) //ндекс по значению
        {
            if (length != 0)
            {
                int i = 0;
                Node tmp = root;

                while (tmp.Value != a && tmp.Next != null)
                {
                    tmp = tmp.Next;
                    i++;
                }
                return i;

            }
            else
            {
                return 0;
            }
        }
        public void DeleteByIndex(int a, int b) //удаление по индексу несколько элементов  
        {

            if (length != 0)
            {

                if (length > 1)
                {
                    if (a < length && a != 0&&a!=length-1)
                    {

                        for (int i = 0; i < b; i++)
                        {
                            IndexDelet(a);
                        }
                    }
                    else if (a == 0)
                    {
                        DeletToStart(b);
                    }
                    else if (a >= length - 1)
                    {
                        DeletToEnd();
                    }
                }
                else
                {
                    root = null;
                    length = 0;
                }

            }

        }





    }
}
