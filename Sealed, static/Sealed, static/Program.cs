using System;

namespace Sealed__static
{
    enum DaysOfWeek { Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test
            //{
            //    Name = "Ali",
            //    Age = 20,
            //    StudentCode = "a1231",
            //    Lessons = new string[] { "Html", "Css", "Js" }
            //};
            //t.GetInfo();
            //Student s = new Student
            //{
            //    Name = "Ali",
            //    Age = 20,
            //    StudentCode = "a1231"
            //};
            //Student s1 = new Student
            //{
            //    Name = "Vaqif",
            //    Age = 17,
            //    StudentCode = "a1232"
            //};
            //Test t = new Test();
            //Test.GetName();

            //Test.Random();
            //PrintHW();

            //Test t = new Test { Name = "Ismayil" };
            //Test t1 = new Test() { Name = "Elnur" };
            //Test t2 = new Test { Name = "Rovshen" };
            //Test t3 = new Test { Name = "Asgar" };
            //Console.WriteLine($"T : {t.Id} \nT1 : {t1.Id} \nT2 : {t2.Id} \nT3 : {t3.Id}");
            //Console.WriteLine("Text-i daxil edin");
            //string str = Console.ReadLine();
            //Console.WriteLine(str.MakeCapital(1,true));
            //int a = 25;
            //Console.WriteLine(a.Add(25));
            //int a = null;
            //int? a = 5;
            //string? b = null;
            int day = 3;
            switch (day)
            {
                case (int)DaysOfWeek.Monday:
                    Console.WriteLine(DaysOfWeek.Monday);
                    break;
                case (int)DaysOfWeek.Tuesday:
                    Console.WriteLine(DaysOfWeek.Tuesday);
                    break;
                case (int)DaysOfWeek.Wednesday:
                    Console.WriteLine(DaysOfWeek.Wednesday);
                    break;
                case (int)DaysOfWeek.Thursday:
                    Console.WriteLine(DaysOfWeek.Thursday);
                    break;
                case (int)DaysOfWeek.Friday:
                    Console.WriteLine(DaysOfWeek.Friday);
                    break;
                case (int)DaysOfWeek.Saturday:
                    Console.WriteLine(DaysOfWeek.Saturday);
                    break;
                case (int)DaysOfWeek.Sunday:
                    Console.WriteLine(DaysOfWeek.Sunday);
                    break;
            }
        }
        //public static void PrintHW()
        //{
        //    Console.WriteLine("Hello World");
        //}
    }

}
