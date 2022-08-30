using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non-generic
            //MyList list = new MyList();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //MyList listStr = new MyList();
            //listStr.Add("ksjdfjksd");
            //listStr.Add("skjdhfskdj");
            //listStr.Add("asd");
            //listStr.Add(true);
            //listStr.Add(23);
            //for (int i = 0; i < listStr.Count; i++)
            //{
            //    Console.WriteLine(listStr[i]);
            //}
            ArrayList arrayList = new ArrayList();
            Hashtable ht = new Hashtable();
            ht.Add("Esger", new Student { Name ="Asgar" });
            Console.WriteLine(((Student)ht["Esger"]).Name);
            #endregion
            #region Generic
            #region List
            MyList<float,int,int,bool> myList = new MyList<float, int, int, bool>();
            //MyList<Student> list = new MyList<Student>();
            //MyList<string> list2 = new MyList<string>();
            //list.Add(new Student { Name = "Asgar", Surname = "Asgarov", Age = 23 });
            //list.Add(new Student { Name = "Rovshen", Surname = "Xelilov", Age = 19 });
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine($"{list[i].Name} {list[i].Surname} {list[i].Age}");
            //}
            List<int> list1 = new List<int>();
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);
            list1.Add(8);
            list1.Insert(2, 10);
            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Linked List
            LinkedList<int> ll = new LinkedList<int>();
            #endregion
            #endregion
        }
    }
    #region Generic
    class MyList<T,U,V,Z> where T : new()
        //T: class, IEnumerable, new()
        //T : class
        //T : U
        //T: A
        //T : IEnumerable
    {
        T[] _arr;
        public int Count { get => _arr.Length; }
        public MyList()
        {
            _arr = new T[0];
            T a = new T();
        }
        public T this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(T value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }
    class A
    {

    }
    class B : A
    {

    }
    class C : B
    {

    }
    #endregion

    #region Non-generic
    //class MyList
    //{
    //    object[] _arr;
    //    public int Count { get => _arr.Length; }
    //    public MyList()
    //    {
    //        _arr = new string[0];
    //    }
    //    public object this[int index]
    //    {
    //        get
    //        {
    //            if (index < _arr.Length)
    //            {
    //                return _arr[index];
    //            }
    //            throw new IndexOutOfRangeException();
    //        }
    //        set
    //        {
    //            if (index < _arr.Length)
    //            {
    //                _arr[index] = value;
    //            }
    //            throw new IndexOutOfRangeException();
    //        }
    //    }
    //    public void Add(object value)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = value;
    //    }
    //}
    #endregion
}
