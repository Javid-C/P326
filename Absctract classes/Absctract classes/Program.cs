using System;

namespace Absctract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1 t1 = new Test1();
            //Console.WriteLine(t1.Min(3, 7));
            //Eagle e = new Eagle();
            //Shark s = new Shark();
            //Sparrow sp = new Sparrow();
            ////s.Grow();
            ////e.Eat();
            ////s.Eat();
            ////e.Grow();
            //Animal[] animals = { e, s, sp };
            //foreach (var item in animals)
            //{
            //    item.Grow();
            //}
            Calculate c = new Calculate();
            Console.WriteLine(c.Divide(25, 5));
        }
    }
    class Test
    {
        public string MyProperty { get; set; }
    }
    abstract class Animal:Test
    {
        private void A()
        {
            Console.WriteLine("Salam");
        }
        public abstract void Eat();
        public virtual void Grow()
        {
            Console.WriteLine("Grew");
        }
    }
    abstract class Fish : Animal
    {
        public abstract void Swim();
    }
    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Shark ate");
        }

        public override void Swim()
        {
            Console.WriteLine("Shark swam");
        }
        public override void Grow()
        {
            Console.WriteLine("Shark grew");
        }
    }
    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle ate");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle flew");
        }
        public override void Grow()
        {
            Console.WriteLine("Eagle grew");
        }
    }
    class Sparrow : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Sparrow ate");
        }

        public override void Fly()
        {
            Console.WriteLine("Sparrow flew");
        }
    }

    //abstract class Test
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("Hello World");
    //    }
    //    public abstract int Min(int num1, int num2);
    //}

    //class Test1 : Test
    //{
    //    public override int Min(int num1, int num2)
    //    {
    //        if (num1>num2)
    //        {
    //            return num2;
    //        }
    //        return num1;
    //    }
    //}
    interface IDivide
    {
        double Divide(double num1, double num2);
    }
    interface ISum
    {
        int Sum(int num1, int num2);
    }
    interface IDifference
    {
        int Difference(int num1, int num2);
    }
    interface IProduct
    {
        long Product(int num1, int num2);
    }
    class Calculate : ISum,IDivide,IProduct
    {
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public long Product(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
