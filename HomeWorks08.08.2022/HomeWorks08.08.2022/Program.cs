using System;

namespace HomeWorks08._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= { 1,2,3,4};
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Math.Min(1,2);
            SwapMinAndMax(ref array);
            Console.WriteLine("---------");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void SwapMinAndMax(ref int[] arr)
        {
            int mini = 0, maxi = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[mini] > arr[i])
                {
                    mini = i;
                }
                else if(arr[maxi] < arr[i])
                {
                    maxi = i;
                }
            }
            arr[maxi] = arr[maxi] + arr[mini];
            arr[mini] = arr[maxi] - arr[mini];
            arr[maxi] = arr[maxi] - arr[mini];
        }
    }
}
