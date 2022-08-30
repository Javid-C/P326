using System;

namespace HomeWorks04._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[] arr = { 1,4,6,-8,0,16};
            //Console.WriteLine(Min(arr));
            #endregion
            #region Task2
            Console.WriteLine("Neyin sahesi lazimdir? \n 1. Cevre \n 2. 4bucaqli \n 3.Paralelepiped");
            Console.WriteLine(Area(4,6,10));
            #endregion
        }
        #region Task1
        static int Min(int[] arr)
        {
            int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            foreach (int item in arr)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }
        #endregion
        #region Task2
        /// <summary>
        /// For cirlce
        /// </summary>
        /// <param name="r">Radius</param>
        /// <returns>Area of circle</returns>
        static float Area(float r)
        {
            return 3*r*r;
        }
        /// <summary>
        /// For rectangle
        /// </summary>
        /// <param name="a">side 1</param>
        /// <param name="b">side 2</param>
        /// <returns>Area of rectangle</returns>
        static float Area(float a, float b)
        {
            return a * b;
        }
        static float Area(float a, float b, float c)
        {
            return 2 * (a * b + a * c + b * c);
        }
        static float Area(float a, float b, float c, float r)
        {
            return r * (a + b + c) / 2;
        }
        #endregion
    }
}
