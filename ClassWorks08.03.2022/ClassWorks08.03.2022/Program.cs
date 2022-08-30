using System;

namespace ClassWorks08._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Enter the number :");
            //int number = int.Parse(Console.ReadLine());
            //int power = int.Parse(Console.ReadLine());
            //Console.WriteLine(Power(number, power));
            #endregion
            #region Task2
            string name = "Ali"; //Console.ReadLine();
            string surname = "Huseynov"; //Console.ReadLine();
            string fatherName = "Abbas";//Console.ReadLine();
            Console.WriteLine("Overload 1");
            Print(name);
            Console.WriteLine("Overload 2");
            Print(name,surname);
            Console.WriteLine("Overload 3");
            Print(name, surname, fatherName);
            #endregion

        }
        #region Task1
        //static int Power(int num, int pow = 2)
        //{
        //    int prod = 1;
        //    for (int i = 0; i < pow; i++)
        //    {
        //        prod = prod * num;
        //    }
        //    return prod;
        //}
        #endregion
        #region Task2
        static void Print(string name)
        {
            Console.WriteLine(name);
        }
        static void Print(string name, string surname)
        {
            Console.WriteLine(name + " "+surname);
        }
        static void Print(string name, string surname, string fatherName)
        {
            Console.WriteLine(name + " "+ fatherName[0] +". " + surname);
        }
        #endregion
    }
}
