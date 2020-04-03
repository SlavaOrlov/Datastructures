using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace datastructures
{
    public class ArrayList : IDataStructures1
    {
        private int[] array;
        private int length;

        public ArrayList()
        {
            array = new int[0];
            length = 0;
        }
        public ArrayList(int a)
        {
            array = new int[1] { a };
            length = 1;
        }
        public ArrayList(int[] a)
        {
            array = a;
            length = a.Length;
        }
        public void UpArraySize() // разширение массива на 30%
        {
            int newLength = Convert.ToInt32(array.Length * 1.3 + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public void AddToEnd(int a) //добавление нового элемента в конец 
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }
            array[length] = a;
            length++;
        }
        public void AddToEnd(int[] a) //добавление нескольких элементов в конец 
        {
            while (length + a.Length > array.Length)
            {
                UpArraySize();
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[length + i] = a[i];
            }
            length += a.Length;
        }
        public void AddToStart(int a) //добавление нового элемента в начало
        {
            if (length >= array.Length)
            {
                UpArraySize();
            }
            for (int i = array.Length - 2; i >= 0; i--)
            {
                array[i + 1] = array[i];
            }
            array[0] = a;
            length++;

        }
        public void AddToStart(int[] a) //добавление нескольких элементов в начало
        {
            while (length + a.Length > array.Length)
            {
                UpArraySize();
            }
            for (int i = length - 1; i >= 0; i--)
            {
                array[i + a.Length] = array[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }
            length += a.Length;

        }

        public void IndexAdding(int a, int b) //добавление по индексу  
        {
            if (length >= array.Length || a > length - 1)
            {
                UpArraySize();
            }

            if (a < length - 1)
            {
                length++;
                for (int i = array.Length - 2; i >= a; i--)
                {
                    array[i + 1] = array[i];
                }
                array[a + 1] = b;
            }
            else
            {
                AddToEnd(b);
            }
        }
        public void DeletToEnd(int a) // удаление N элеметов с конца
        {
            if (array.Length != 0)
            {
                if (a >= array.Length)
                {
                    array = new int[] { };
                    length = 0;
                }
                else
                {

                    int newLength = Convert.ToInt32(array.Length - a);
                    int[] newArray = new int[newLength];
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        newArray[i] = array[i];
                    }
                    array = newArray;
                    length -= a;
                }

            }
        }
        public void DeletToEnd() // удаление 1 элеметов с конца
        {
            if (array.Length != 0)
            {

                int newLength = Convert.ToInt32(array.Length - 1);
                int[] newArray = new int[newLength];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                length--;
            }
        }
        public void DeletToStart(int a) // удаление N элеметов с начала
        {
            if (array.Length != 0)
            {

                for (int i = 0; i < length - a; i++)
                {
                    array[i] = array[i + a];
                }

                length -= a;
            }
        }
        public void DeletToStart() // удаление 1 элеметов с начала
        {
            if (array.Length != 0)
            {

                for (int i = 0; i < length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                length--;
            }
        }
        public void IndexDelet(int a) //удаление по индексу  
        {

            if (array.Length != 0)
            {
                if (a >= array.Length)
                {
                    DeletToEnd();
                }
                else
                {
                    for (int i = a; i < length - 1; i++)
                    {
                        array[i] = array[i + 1];
                    }
                    length--;
                }

            }
        }
        public int this[int a] //возвращение значения по индексу 
        {
            get //возвращение значения по индексу
            {
                if (length != 0)
                {
                    if (a > array.Length - 1)
                    {
                        return array[length - 1];
                    }
                    else
                    {
                        return array[a];
                    }
                }
                else
                {
                    return 0;
                }
            }
            set //изменение значения по индексу 
            {
                if (a <= array.Length - 1)
                {
                    array[a] = value;
                }
            }
        }
        public int[] ReturnArray() //возвращение массива 
        {
            int[] arrayToReturn = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayToReturn[i] = array[i];
            }
            return arrayToReturn;
        }
        public void Revers6() //реверс массива 
        {

            for (int i = 0; i < length - 1 - i; i++)
            {
                int tmp = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = tmp;
            }


        }
        public int MinEl1 //минимальный значение элемента в  массиве 
        {
            get
            {

                if (length != 0)
                {

                    int min = array[0];
                    for (int i = 1; i < length; i++)
                    {
                        if (min > array[i])
                        {
                            min = array[i];
                        }
                    }
                    return min;
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

                if (length != 0)
                {

                    int max = array[0];
                    for (int i = 1; i < length; i++)
                    {
                        if (max < array[i])
                        {
                            max = array[i];
                        }
                    }
                    return max;
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
                if (length != 0)
                {

                    int min = array[0];
                    int q = 0;

                    for (int i = 1; i < length; i++)
                    {
                        if (min > array[i])
                        {
                            min = array[i];
                            q = i;
                        }
                    }
                    return q;
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

                if (length != 0)
                {
                    int max = array[0];
                    int q = 0;

                    for (int i = 1; i < length; i++)
                    {
                        if (max < array[i])
                        {
                            max = array[i];
                            q = i;
                        }
                    }
                    return q;
                }
                else
                {
                    return 0;
                }
            }
        }
        public void Bubble9() //значения массива по возвростанию 
        {
            int g = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        g = array[i];
                        array[i] = array[j];
                        array[j] = g;
                    }
                }

            }

        }
        public void Select10() //значения массива по убыванию 
        {
            for (int i = 0; i < length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;
                    }
                }
                int tmp = array[min];
                array[min] = array[i];
                array[i] = tmp;
            }
        }

        public void DeleteByValue(int a) //удаление по значению 
        {
            if (length != 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i] % a == 0)
                    {
                        for (int j = i; j < length - 1; j++)
                        {
                            array[j] = array[j + 1];

                        }
                        length--;
                    }
                }
            }
        }
        public int IndexValue(int a) //ндекс по значению
        {
            if (length != 0)
            {
                int b = 0;
                for (int i = 0; i < length; i++)
                {
                    if (array[i] == a)
                    {
                        b = i;
                        break;
                    }
                    else
                    {
                        b = length - 1;
                    }
                }
                return b;
            }
            else
            {
                return 0;
            }
        }
        public void DeleteByIndex(int a, int b) //удаление по индексу несколько элементов  
        {

            if (array.Length != 0)
            {

                if (a != 0 && a < length - 1)
                {
                    for (int i = 0; b + 1 + i <= length - 1; i++)
                    {
                        array[a + i] = array[b + 1 + i];
                    }
                    length -= b;
                }
                else if (a >= length - 1)
                {
                    DeletToEnd();
                }
                else if (a == 0)
                {
                    DeletToStart(b);
                }

            }

        }

    }
}