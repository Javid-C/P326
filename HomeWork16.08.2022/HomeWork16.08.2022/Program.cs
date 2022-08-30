using HomeWork16._08._2022.Models.Classes;
using System;

namespace HomeWork16._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            MenuWithGoTo();
        }
        static void MenuWithGoTo()
        {
            Input:
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Kvadratın tərəfini daxil edin");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Square s = new Square(side);
                    Console.WriteLine(s.CalcArea());
                    break;
                case 2:
                    Console.WriteLine("Düzbucaqlının tərəflərini daxil edin");
                    Console.Write("Uzunluq :");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("En :");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Rectangular r = new Rectangular(width, length);
                    Console.WriteLine(r.CalcArea());
                    break;
                default:
                    Console.WriteLine("Wrong info");
                    break;
            }
            if (a!=0)
            {
                goto Input;
            }
        }
        static void MenuWithWhile()
        {
            int a;
            do
            {
                Console.WriteLine("İstədiyin fiquru seçin \n1.Kvadrat \n2.Düzbucaqlı \n0.Çıxış");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Kvadratın tərəfini daxil edin");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Square s = new Square(side);
                        Console.WriteLine(s.CalcArea());
                        break;
                    case 2:
                        Console.WriteLine("Düzbucaqlının tərəflərini daxil edin");
                        Console.Write("Uzunluq :");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("En :");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Rectangular r = new Rectangular(width, length);
                        Console.WriteLine(r.CalcArea());
                        break;
                    default:
                        Console.WriteLine("Wrong info");
                        break;
                }
            } while (a!=0);
        }
        static void Menu(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Kvadratın tərəfini daxil edin");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Square s = new Square(side);
                    Console.WriteLine(s.CalcArea());
                    break;
                case 2:
                    Console.WriteLine("Düzbucaqlının tərəflərini daxil edin");
                    Console.Write("Uzunluq :");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("En :");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Rectangular r = new Rectangular(width, length);
                    Console.WriteLine(r.CalcArea());
                    break;
                default:
                    Console.WriteLine("Wrong info");
                    break;
            }
            GetMenu();
        }
        static void GetMenu()
        {
            Console.WriteLine("İstədiyin fiquru seçin \n1.Kvadrat \n2.Düzbucaqlı \n0.Çıxış");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                Menu(input);
            }
        }
    }
}
