using System;
using System.Collections.Generic;
using System.Text;

namespace datastructures
{
    public interface IDataStructures1
    {
        
        public void AddToEnd(int a); //добавление нового элемента в конец +++
        public void AddToEnd(int[] a); //добавление нескольких элементов в конец +++
        public void AddToStart(int a); //добавление нового элемента в начало +++
        public void AddToStart(int[] a); //добавление нескольких элементов в начало +++
        public void IndexAdding(int a, int b); //добавление по индексу  +++
        public void DeletToEnd(int a); // удаление N элеметов с конца +++
        public void DeletToEnd();// удаление 1 элеметов с конца +++
        public void DeletToStart(int a); // удаление N элеметов с начала +++
        public void DeletToStart(); // удаление 1 элеметов с начала +++
        public void IndexDelet(int a); //удаление по индексу  +++
        public int this[int a] //возвращение значения по индексу +++
        {
            get; //возвращение значения по индексу +++
            set; //изменение значения по индексу +++
        }
        public int[] ReturnArray(); //возвращение массива +++
        public void Revers6(); //реверс массива +++
        public int MinEl1 { get; } //минимальный значение элемента в  массиве +++
        public int MaxEl2 { get; } //максимальне значение элемент в  массиве+++
        public int MinIndex3 { get; } //индекс минимального значения элемента в массиве +++
        public int MaxIndex4 { get; } //индекс максимального значения элемента в массиве +++
        public void Bubble9(); //значения массива по возвростанию ++
        public void Select10(); //значения массива по убыванию ++
        public void DeleteByValue(int a); //удаление по значению +++
        public int IndexValue(int a); //ндекс по значению +
        public void DeleteByIndex(int a, int b); //удаление по индексу несколько элементов  
       
                
    }
}
