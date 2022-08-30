using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(1,"2"));
            Test(2,3,5);
        }
        static void Test(int num1, int num2 = 10)
        {
            Console.WriteLine("Default value method");
        }
        static void Test(int num1)
        {
            Console.WriteLine("Simple Method");
        }
        static void Test(params int[] num1)
        {
            Console.WriteLine("Params");
        }







        //method signature - method name, method parameters count, method parameter`s type
        //static int Sum(int num1, int num2)
        //{
        //    return num1 + num2;
        //}
        //static int Sum(int num1, int num2, int num3)
        //{
        //    return num1 + num2 + num3;
        //}
        //static string Sum(int num1, string num2)
        //{
        //    return num1 + num2 + "";
        //}
        //static int SumArray(int num, int num2 = 21, params int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        ///// <summary>
        ///// Sum 2 numbers
        ///// </summary>
        ///// <param name="num1">First number</param>
        ///// <param name="num2">Second nummber</param>
        ///// <returns>Sum of these numbers</returns>
        //static int Sum(int num1, int num2, int num3 = 20)
        //{
        //    return num1 + num2 + num3;
        //}
        //static void Print()
        //{
        //    Console.WriteLine(Sum(4, 6));
        //    return;
        //}

    }
}
