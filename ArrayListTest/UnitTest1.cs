using NUnit.Framework;
using datastructures;
using datastructures.LinkedList;
using datastructures.L2LinkedList;
namespace ArrayListTest
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]
    public class Tests
    {
        IDataStructures1 list;
        int q;
        public Tests(int _q)
        {
            q = _q;
        }


        [SetUp]
        public void ListSelect()
        {
            switch (q)
            {
                case 1:
                    list = new ArrayList();
                    break;
                case 2:
                    list = new LinkedList();
                    break;
                case 3:
                    list = new L2LinkedList();
                    break;
            }
        }







        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]   //несколько к конец 
        [TestCase(new int[] { 1 }, new int[] { 4, 5 }, ExpectedResult = new int[] { 1, 4, 5 })]
        [TestCase(new int[] { }, new int[] { 4, 5 }, ExpectedResult = new int[] { 4, 5 })]
        [TestCase(new int[] { }, new int[] { }, ExpectedResult = new int[] { })]


        public int[] AddToEndTest(int[] array, int[] a)
        {
            list.AddToEnd(array);
            list.AddToEnd(a);
            return list.ReturnArray();
            
            
        }





        [TestCase(new int[] { 1, 2 }, 4, ExpectedResult = new int[] { 1, 2, 4 })]    //один в конец 
        [TestCase(new int[] { 1 }, 4, ExpectedResult = new int[] { 1, 4 })]
        [TestCase(new int[] { }, 4, ExpectedResult = new int[] { 4 })]

        public int[] AddToEndTest(int[] array, int a)
        {
            list.AddToEnd(array);
            list.AddToEnd(a);
            return list.ReturnArray();
        }






        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7, 8 }, ExpectedResult = new int[] { 4, 5, 6, 7, 8, 1, 2, 3 })]   //несколько в начало 
        [TestCase(new int[] { }, new int[] { 4, 5, 7, 8 }, ExpectedResult = new int[] { 4, 5, 7, 8 })]
        [TestCase(new int[] { }, new int[] { }, ExpectedResult = new int[] { })]

        public int[] AddToStartTest(int[] array, int[] a)
        {
            list.AddToEnd(array);
            list.AddToStart(a);
            return list.ReturnArray();
        }






        [TestCase(new int[] { 1, 2, 3 }, 6, ExpectedResult = new int[] { 6, 1, 2, 3 })]    //один в начало 
        [TestCase(new int[] { 1 }, 4, ExpectedResult = new int[] { 4, 1 })]
        [TestCase(new int[] { }, 4, ExpectedResult = new int[] { 4 })]


        public int[] AddToStartTest(int[] array, int a)
        {
            list.AddToEnd(array);
            list.AddToStart(a);
            return list.ReturnArray();
        }




        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 3, 2, 1 })] //реверс 
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]

        public int[] ReversTest(int[] array)
        {
            list.AddToEnd(array);
            list.Revers6();
            return list.ReturnArray();
        }




        [TestCase(new int[] { 5, 4, 3, 2, 1 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })] //сортировка по возврастанию 
        [TestCase(new int[] { 1, 4, 3, 2, 5 }, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]

        public int[] BubbleTest(int[] array)
        {
            list.AddToEnd(array);
            list.Bubble9();
            return list.ReturnArray();
        }




        [TestCase(new int[] { 4, 21, 3 }, ExpectedResult = new int[] { 21, 4, 3 })]   //сортировка по убыванию 
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, ExpectedResult = new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 4, 3, 2, 5 }, ExpectedResult = new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]

        public int[] SelectTest(int[] array)
        {
            list.AddToEnd(array);
            list.Select10();
            return list.ReturnArray();
        }


        [TestCase(new int[] { 3, 4, 5, 6 }, 1, 7, ExpectedResult = new int[] { 3, 4, 7, 5, 6 })]   // добавлене по индексу 
        [TestCase(new int[] { }, 6, 5, ExpectedResult = new int[] { 5 })]

        public int[] IndexAddingTest(int[] array, int a, int b)
        {
            list.AddToEnd(array);
            list.IndexAdding(a, b);
            return list.ReturnArray();
        }




        [TestCase(new int[] { 4, 21 }, ExpectedResult = new int[] { 4 })]   //удаление с конца 1 эл 
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 1 }, ExpectedResult = new int[] { })]

        public int[] DeletToEndTest(int[] array)
        {
            list.AddToEnd(array);
            list.DeletToEnd();
            return list.ReturnArray();
        }




        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 2, ExpectedResult = new int[] { 4, 21, 33, 4 })]   //удаление с конца нескольких эл 
        [TestCase(new int[] { 1 }, 0, ExpectedResult = new int[] { 1 })]
        [TestCase(new int[] { 1, 3, 4 }, 5, ExpectedResult = new int[] { })]

        public int[] DeletToEndTest(int[] array, int a)
        {
            list.AddToEnd(array);
            list.DeletToEnd(a);
            return list.ReturnArray();
        }



        [TestCase(new int[] { 0, 0, 0, 0, 4, 21 }, 4, ExpectedResult = new int[] { 4, 21 })]   //удаление с начала нескольких эл 
        [TestCase(new int[] { }, 5, ExpectedResult = new int[] { })]

        public int[] DeletToSrartTest(int[] array, int a)
        {
            list.AddToEnd(array);
            list.DeletToStart(a);
            return list.ReturnArray();
        }
        [TestCase(new int[] { 4, 21 }, ExpectedResult = new int[] { 21 })]   //удаление с начала 1 эл 
        [TestCase(new int[] { }, ExpectedResult = new int[] { })]

        public int[] DeletToSrartTest(int[] array)
        {
            list.AddToEnd(array);
            list.DeletToStart();
            return list.ReturnArray();
        }




        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 2, ExpectedResult = new int[] { 4, 21, 4, 5, 5 })]   //удаление по ндексу
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 5, ExpectedResult = new int[] { 4, 21, 33, 4, 5 })]
        [TestCase(new int[] { 4, 21 }, 1, ExpectedResult = new int[] { 4 })]
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 6, ExpectedResult = new int[] { 4, 21, 33, 4, 5 })]
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 0, ExpectedResult = new int[] { 21, 33, 4, 5, 5 })]
        [TestCase(new int[] { }, 5, ExpectedResult = new int[] { })]

        public int[] IndexDeletTest(int[] array, int a)
        {
            list.AddToEnd(array);
            list.IndexDelet(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 2, ExpectedResult = 33)]   // возвращене значеня по индексу 
        [TestCase(new int[] { }, 5, ExpectedResult = 0)]

        public int ThisGetTest(int[] array, int a)
        {
            list.AddToEnd(array);

            return list[a];
        }


        [TestCase(new int[] { }, 40, 22, ExpectedResult = new int[] { })]   //  изменение значения по индексу 
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 2, 22, ExpectedResult = new int[] { 4, 21, 22, 4, 5, 5 })]

        public int[] ThisSetTest2(int[] array, int a, int b)
        {
            list.AddToEnd(array);
            list[a] = b;
            return list.ReturnArray();

        }



        [TestCase(new int[] { }, ExpectedResult = 0)]   //  мнимальный элемент  
        [TestCase(new int[] { 4, 21, 33, 7, 5, 5 }, ExpectedResult = 4)]

        public int MinElTest(int[] array)
        {
            list.AddToEnd(array);

            return list.MinEl1;

        }




        [TestCase(new int[] { }, ExpectedResult = 0)]   //  мнимальный элемент  
        [TestCase(new int[] { 4, 21, 33, 7, 5, 5 }, ExpectedResult = 33)]

        public int MaxElTest(int[] array)
        {
            list.AddToEnd(array);
            return list.MaxEl2;
        }




        [TestCase(new int[] { }, ExpectedResult = 0)]   //  мнимальный элемент  
        [TestCase(new int[] { 1, 21, 33, 7, 5, 9 }, ExpectedResult = 0)]

        public int MinIndexTest(int[] array)
        {
            list.AddToEnd(array);
            return list.MinIndex3;
        }



        [TestCase(new int[] { }, ExpectedResult = 0)]   //  мнимальный элемент  
        [TestCase(new int[] { 13, 21, 33, 7, 5, 9 }, ExpectedResult = 2)]

        public int MaxIndexTest(int[] array)
        {
            list.AddToEnd(array);
            return list.MaxIndex4;
        }



        [TestCase(new int[] { }, 5, ExpectedResult = new int[] { })]   //  мнимальный элемент  
        [TestCase(new int[] { 13, 21, 33, 7, 5, 9 }, 33, ExpectedResult = new int[] { 13, 21, 7, 5, 9 })]

        public int[] DeleteByValueTest(int[] array, int a)
        {
            list.AddToEnd(array);
            list.DeleteByValue(a);
            return list.ReturnArray();
        }


        [TestCase(new int[] { }, 5, ExpectedResult = 0)]   //  индекс по значению  
        [TestCase(new int[] { 13, 21, 33, 7, 5, 9 }, 123, ExpectedResult = 5)]
        [TestCase(new int[] { 13, 21, 33, 7, 5, 9 }, 33, ExpectedResult = 2)]

        public int IndexValueTest(int[] array, int a)
        {
            list.AddToEnd(array);

            return list.IndexValue(a);
        }
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 2, 3, ExpectedResult = new int[] { 4, 21, 5 })]   //удаление по ндексу N элементов 
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 5, 2, ExpectedResult = new int[] { 4, 21, 33,4  ,5 })]
        [TestCase(new int[] { 4, 21 }, 1,1, ExpectedResult = new int[] { 4 })]
        [TestCase(new int[] { 4, 21, 33, 4, 5, 5 }, 6, 2, ExpectedResult = new int[] { 4, 21, 33, 4, 5 })]
        [TestCase(new int[] { 4, 21, 33, 7, 5, 5 }, 0, 3, ExpectedResult = new int[] { 7, 5, 5})]
        [TestCase(new int[] { }, 5, 2, ExpectedResult = new int[] { })]

        public int[] DeleteByIndexTest(int[] array, int a, int b)
        {
            list.AddToEnd(array);
            list.DeleteByIndex(a, b);
            return list.ReturnArray();
        }
    }
}