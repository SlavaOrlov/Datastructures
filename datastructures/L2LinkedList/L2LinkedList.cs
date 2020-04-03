using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace datastructures.L2LinkedList
{
    public class L2LinkedList:IDataStructures1
    {
        private L2Node root;
        private L2Node end;
        private int length;

        public L2LinkedList()
        {
            root = null;
            end = null;
            length = 0;
        }
        public L2LinkedList(int a)
        {
            root = new L2Node(a);
            end = root;
            length = 1;
        }
        public L2LinkedList(int [] a)
        {
            if (a.Length != 0)
            {
                root = null;
                end = null;
                length = 0;
                AddToEnd(a);
            }

        }

        public void AddToEnd(int a) //добавление в конец 1 элемента
        {
            if (length == 0)
            {
                root = new L2Node(a);
                end = root;
                length = 1;
            }
            else
            {
                end.Next = new L2Node(a);
                end.Next.Previous = end;
                end = end.Next;
                length++;
            }
        }
        
        public void AddToEnd(int[] a) //добавление в конец N элементов 
        {
            if (a.Length != 0)
            {

                if (length == 0)
                {
                    root = new L2Node(a[0]);
                    end = root;
                    for (int i = 1; i < a.Length; i++)
                    {
                        end.Next = new L2Node(a[i]);
                        end.Next.Previous = end;
                        end = end.Next;

                    }
                    length = a.Length;
                }
                else
                {
                    
                    for (int i = 0; i < a.Length; i++)
                    {
                        end.Next = new L2Node(a[i]);
                        end.Next.Previous = end;
                        end = end.Next;
                    }
                    length += a.Length;
                }
            }
        }
        public void AddToStart(int a) //добавление в начало 1 элемента 
        {
            if (length == 0)
            {
                root = new L2Node(a);
                end = root;
                length = 1;
            }
            else
            {
                root.Previous = new L2Node(a);
                root.Previous.Next = root;
                root = root.Previous;
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
                        root.Previous = new L2Node(a[i]);
                        root.Previous.Next = root;
                        root = root.Previous;
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
                L2Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                } while (tmp != null);
            }
            
            return array;
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
                    L2Node tmp = root;
                    for (int i = 0; i < a && tmp.Next != null; i++)
                    {
                        tmp = tmp.Next;
                    }
                    L2Node tmp2 = new L2Node(b);
                    tmp2.Next = tmp.Next;
                    tmp.Next.Previous = tmp2.Next;
                    tmp.Next = tmp2;
                    tmp2.Previous = tmp.Next;
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
                end = null;
                length = 0;
            }
            else
            {
                end = end.Previous;
                end.Next = null;
                length--;
            }
        }
        public void DeletToEnd(int a)// удаление N элеметов с конца
        {
            if (a <= length && a >= 0)
            {

                if (length != 0)
                {

                    L2Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        end = end.Previous;
                        end.Next = null;
                    }
                    
                    length -= a;
                }
            }
            else
            {
                root = null;
                end = null;
                length = 0;
            }

        }
        public void DeletToStart() // удаление 1 элеметов с начала 
        {
            if (length <= 1)
            {
                root = null;
                end = null;
                length = 0;
            }
            else
            {
                root = root.Next;
                root.Previous = null;
                length--;
            }
        }
        public void DeletToStart(int a) // удаление N элеметов с начала 
        {
            if (a <= length && a >= 0)
            {

                if (length != 0)
                {
                    for (int i = a; i >= 1; i--)
                    {
                        root = root.Next;
                        root.Previous = null;
                    }
                    length -= a;
                }
            }
            else
            {
                root = null;
                end = null;
                length = 0;
            }
        }
        public void Revers6() //реверс массива 
        {
            if (length != 0)
            {
                L2Node tmproot = root;
                L2Node tmpend = end;
                while (tmproot != tmpend&&tmproot.Previous!=end)
                {
                    int i = tmproot.Value;
                    tmproot.Value = tmpend.Value;
                    tmpend.Value = i;
                    tmproot = tmproot.Next;
                    tmpend = tmpend.Previous;
                }
            }
        }

        public int MinEl1 //минимальный значение элемента в  массиве 
        {
            get
            {
                L2Node tmp = root;
                L2Node min = root;
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
                L2Node tmp = root;
                L2Node max = root;
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
                L2Node index = new L2Node(0);
                L2Node tmp = root;
                L2Node min = root;
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
                L2Node index = new L2Node(0);
                L2Node tmp = root;
                L2Node max = root;
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
        public void IndexDelet(int a) //удаление по индексу  +
        {
            if (length > 1)
            {
                if (a < length && a != 0)
                {
                    L2Node tmp = root;
                    
                    for (int i = 1; i < a; i++)
                    {
                        tmp = tmp.Next;
                        tmp.Next.Previous = tmp;
                    }
                    tmp.Next = tmp.Next.Next;
                    length--;
                }
                else if (a == 0)
                {
                    DeletToStart();
                }
                else if (a >= length-1)
                {
                    DeletToEnd();
                }
                
            }
            else
            {
                root = null;
                end = null;
                length = 0;
            }
        }
        public int this[int a] //возвращение значения по индексу +
        {
            get //возвращение значения по индексу
            {
                if (length > 0)
                {
                    L2Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                        tmp.Next.Previous = tmp;
                    }
                    return tmp.Value;
                }
                else { return 0; }
            }

            set  //изменение значения по индексу 
            {
                if (a <= length - 1)
                {
                    L2Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                        tmp.Next.Previous = tmp;
                    }
                    tmp.Value = value;
                }
            }

        }
        public void DeleteByValue(int a) //удаление по значению +
        {
            if (length != 0)
            {

                L2Node tmp = root;
                while (tmp.Next.Value != a && tmp.Next != null)
                {
                    tmp = tmp.Next;
                    tmp.Next.Previous = tmp;
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
                L2Node tmp = root;

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
                    if (a < length && a != 0 && a != length - 1)
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
                    end = null;
                    length = 0;
                }

            }

        }
        public void Bubble9() //значения массива по возвростанию +
        {

            if(length > 1)
            {
                for (int i = 1; i < length; i++)
                {
                    L2Node tmp = root;
                    if (root.Value > tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        root.Previous = tmp;
                        tmp.Next = root;
                        tmp.Previous = null;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        L2Node left = tmp.Next;
                        L2Node right = tmp.Next.Next;
                        if (left.Value > right.Value)
                        {
                            left.Next = right.Next;
                            left.Previous = right;
                            right.Next = left;
                            right.Previous = tmp;
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
                    L2Node tmp = root;
                    if (root.Value < tmp.Next.Value)
                    {
                        tmp = tmp.Next;
                        root.Next = tmp.Next;
                        root.Previous = tmp;
                        tmp.Next = root;
                        tmp.Previous = null;
                        root = tmp;
                    }
                    while (tmp.Next.Next != null)
                    {
                        L2Node left = tmp.Next;
                        L2Node right = tmp.Next.Next;
                        if (left.Value < right.Value)
                        {
                            left.Next = right.Next;
                            left.Previous = right;
                            right.Next = left;
                            right.Previous = tmp;
                            tmp.Next = right;
                        }
                        tmp = tmp.Next;
                    }
                }
            }
        }


    }
}
