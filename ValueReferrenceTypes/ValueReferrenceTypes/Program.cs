using System;

namespace ValueReferrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RestOfLesson
            //int[] numbers = { 10, 7, 56, 22, 39 };
            //for (int i = 0; i < numbers.Length-1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //string text = Console.ReadLine();
            //try
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    Console.WriteLine(number);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Reqem deyil ve ya range ashilib");
            //}
            //Console.WriteLine(text);
            #endregion
            #region Value Types
            //int a = 5;
            //int b = a;
            //b++;
            //Console.WriteLine("value of a:{{0}}a:{0}", a);
            //Console.WriteLine($"value of a:{a}"); // 1. "value of a:{0}{1}",a,b 2. "value of a:"+a
            //Console.WriteLine($"value of b:{b}");
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr1 = { 1,2,3,4,5};
            arr[0] = 20;
            foreach (int item in arr)
            {
                Console.WriteLine("arr: "+item);
            }
            foreach (int item in arr1)
            {
                Console.WriteLine("arr1: "+item);
            }
            #endregion
        }
    }
}
