using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        delegate bool Check(int num);
        //delegate bool Check<T>(T num); // Predicate
        delegate int Calc(int num1, int num2);
        delegate TResult Calc1<in T1,in T2,out TResult>(T1 arg1, T2 arg2); //Func
        delegate void Print<T>(T T1); // Action
        static void Main(string[] args)
        {
            //Func<int, string, bool> funk = Test;
            //SumEven(arr);
            //SumDivide3(arr);
            //Sum(arr);
            //SumDigit(arr);
            //int[] arr = { 1, 2, 3, 4, 8, 9, 10 };

            //Predicate<int> a = delegate (int num)
            //{
            //    return num % 5 == 0;
            //};
            //Predicate<int> a = num => num % 5 == 0;
            //Predicate<string> asd = num => num.Length == 0;
            //Sum(arr, (int num) => num % 5 == 0);
            //Sum(arr, IsDivide3);
            //Sum(arr, IsEven);
            //Sum(arr, IsDigit);
            //Calc1<int, int, int> met = Product;
            //Calculate(4, 5, met);
            //Calculate(20, 14, (int num1, int num2) => num1 - num2);
            //Action<string> p = PrintFull;
            //p += PrintUpper;
            //p += PrintFirstLetter;
            //p += name => Console.WriteLine(name.ToLower());
            //p -= name => Console.WriteLine(name.ToLower());
            //p("Ferid");
            //Action<int, string> act = (int age, string name) => Console.WriteLine(name + " " + age);
            //act(16,"Cehyun");
            //Action<int> percent = n => Console.WriteLine(n*15/100);
            //percent(100);
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(12);
            //list.Add(4);
            //list.Add(11);
            //list.Add(1123);
            //list.Add(15);
            //list.Add(17);
            //list.Add(14);
            //list.Add(19);
            //list.Add(21);
            //list.ForEach(PrintEven);
            //List<int> matches = list.FindAll(num => num % 2 == 0);
            //foreach (var item in matches)
            //{
            //    Console.WriteLine(item);
            //}
            List<Student> students = new List<Student>();
            students.Add(new Student { Name ="Kamran", Age=27});
            students.Add(new Student { Name ="Ferid", Age=25});
            students.Add(new Student { Name ="Leman", Age=19});
            students.Add(new Student { Name ="Tunar", Age=21});
            students.FindAll(std => std.Age > 21 || std.Name == "Leman")
                .ForEach(std => Console.WriteLine(std.Name + " " + std.Age));
        }
        static void PrintEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
        static bool Test(int num, string str)
        {
            return num == str.Length;
        }
        static void Sum(int[] arr, Check check)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                //IsDivide3(item)
                if (check(item))
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
        static void PrintFull(string name)
        {
            Console.WriteLine(name);
        }
        static void PrintFirstLetter(string name)
        {
            Console.WriteLine(name[0]);
        }
        static void PrintUpper(string name)
        {
            Console.WriteLine(name.ToUpper());
        }
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsDivide3(int num)
        {
            return num % 3 == 0;
        }
        static bool IsDigit(int num)
        {
            return num < 10 && num >= 0;
        }
        static void Calculate(int num1, int num2, Calc1<int,int, int> c)
        {
            Console.WriteLine(c(num1, num2));
        }
        static int Sum2Num(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Product(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
