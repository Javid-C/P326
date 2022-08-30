using System;

namespace ref__out
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ref, out
            //int[] a = { 1, 2, 3, 4, 5 };
            ////ChangeNumber(out int a);
            ////Console.WriteLine(a);
            //Console.WriteLine(a[0]);
            //ChangeArray(ref a);
            //Console.WriteLine(a[0]);
            #endregion
            #region Task
            //int[] arr127836182763 = { 1, -2, 3, 4, 5, -78 };
            //foreach (int item in arr127836182763)
            //{
            //    Console.WriteLine(item);
            //}
            //Reverse(arr127836182763);
            //foreach (int item in arr127836182763)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = arr1;
            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]);
            int a = 25;
            Ters(ref a);
            Console.WriteLine(a);
            #endregion
        }
        #region Ref, out
        //static void ChangeArray(ref int[] number)
        //{
        //    number[0] = 121;
        //}

        //static void ChangeNumber(out int number)
        //{
        //    number = 121;
        //}
        #endregion
        #region Task
        static void Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * (-1);
                }
            }
        }
        static void Ters(ref int num)
        {
            int temp = 0;
            while (num > 0)
            {
                temp = temp * 10 + num % 10;
                num /= 10;
            }
            num = temp;
        }
        #endregion
    }
}
