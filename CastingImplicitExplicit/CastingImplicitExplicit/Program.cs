using System;

namespace CastingImplicitExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting, boxing, implicit
            //Sparrow jack = new Sparrow();
            //Shark shark = new Shark();
            //int num = 7;
            //Animal a = jack;
            //object[] arr = { jack, shark, num, a };
            //Object obj = jack;
            //Console.WriteLine(obj.GetType());
            #endregion
            #region Downcasting, unboxing, explicit
            //((Sparrow)a).Fly();
            //foreach (object item in arr)
            //{
            //    //if (item is Sparrow sp)
            //    //{
            //    //    //1 :
            //    //    //Sparrow sparrow = (Sparrow)item;
            //    //    //sparrow.Fly();
            //    //    //2 :
            //    //    //((Sparrow)item).Fly();
            //    //    //3 :
            //    //    sp.Fly();
            //    //}
            //    //Sparrow sparrow = (Sparrow)item;
            //    Sparrow sparrow = item as Sparrow;
            //    if (sparrow != null)
            //    {
            //        sparrow.Fly();
            //    }

            //}

            //string str = Console.ReadLine();
            //Console.WriteLine(int.TryParse(str,out int anotherNum));
            //Console.WriteLine(anotherNum);
            //int.Parse(str);
            //long longNum = 4947483697;
            //int num = (int)longNum;
            //Console.WriteLine(num);
            //int a = 24;
            //object o = a;
            #endregion
            #region Custom implicit, explicit
            //Manat mnt = new Manat(55);
            //Dollar dlr = mnt;
            //Console.WriteLine(dlr.USD);
            #endregion
            #region Operator overload
            Student asgar = new Student { Name = "Asgar", Age = 23 };
            Student toghrul = new Student { Age = 20 };
            Student std = new Student { Name ="Asgar", Age = 21 };
            Console.WriteLine(asgar!=std);
            #endregion
        }

    }
    #region Upcasting, boxing, implicit
    abstract class Animal
    {
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
        public int WingLength { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Sparrow ate");
        }

        public override void Fly()
        {
            Console.WriteLine("Sparrow flew");
        }
    }
    #endregion
    #region Custom implicit, explicit
    class Dollar
    {
        public decimal USD { get; set; }
        public Dollar(decimal usd)
        {
            USD = usd;
        }
        public static explicit operator Manat(Dollar dollar)
        {
            Manat m = new Manat(dollar.USD * 1.7m);
            return m;
        }
        public static implicit operator Dollar(Manat m)
        {
            return new Dollar(Math.Round(m.AZN / 1.7m));
        }
    }
    class Manat
    {
        public decimal AZN { get; set; }
        public Manat(decimal azn)
        {
            AZN = azn;
        }
        //public static implicit operator Manat(Dollar dollar)
        //{
        //    Manat m = new Manat(dollar.USD * 1.7m);
        //    return m;
        //}
        
    }
    #endregion
    #region Operator overload
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static int operator +(Student s1, Student s2)
        {
            return s1.Age + s2.Age;
        }
        public static bool operator ==(Student s1, Student s2)
        {
            //if (s1.Name == s2.Name && s1.Age == s2.Age)
            //{
            //    return true;
            //}
            //return false;
            return s1.Name == s2.Name && s1.Age == s2.Age;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1==s2);
        }
    }
    #endregion
}
