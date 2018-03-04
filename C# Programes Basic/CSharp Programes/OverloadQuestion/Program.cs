using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadQuestion
{
    /*1st Questionn*/
    class Base
    {
        public virtual void Foo(int x)
        {
            Console.WriteLine("Base.Foo(int)");
        }
        public void Foo(object o)
        {
            Console.WriteLine("BASE.Foo(object)");
        }
    }

    class Derived : Base
    {
        public override void Foo(int x)
        {
            Console.WriteLine("Derived.Foo(int)");
        }

        public void Foo(object o)
        {
            Console.WriteLine("Derived.Foo(object)");
        }
        public void Foo(string o)
        {
            Console.WriteLine("Derived.Foo(string)");
        }
        //public void Foo(int o)
        //{
        //    Console.WriteLine("Derived.Foo(int)");
        //}
        public void Foo<T>(params T[] x)
        {
            Console.WriteLine("params T[]");
        }

        //public string Foo(string o)
        //{
        //    Console.WriteLine("Type 'OverloadQuestion.Derived' already defines a member called 'Foo' with the same parameter types");
        //    return "test";
        //}
    }

    class Test
    {
        static void Main()
        {
            Derived d = new Derived();
            int i = 10;
            string x = "x";
            object obj = new object();
            d.Foo(i);   //params T[]  --Because ther is no matching foung=d inderived. It has only voerriden
            Base b = new Derived();
            b.Foo(i);    //Derived.Foo(int)
            b.Foo(obj);   //BASE.Foo(object)
            Base a = new Base();
            a.Foo(i);
            Console.ReadLine();
        }
    }
    /*2nd Questionn*/
    class Foo
    {
        static Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    class Bar
    {
        static int i = Init();

        static int Init()
        {
            Console.WriteLine("Bar");
            return 0;
        }
    }

    //class Test
    //{
    //    static void Main()
    //    {
    //        Foo f = new Foo();
    //        Bar b = new Bar();
    //        Console.ReadLine();
    //    }
    //} 
    /*3rd Question*/
    //class Test
    //{
    //    static void Main()
    //    {
    //        Foo("Hello");
    //        Foo(2);
    //        Console.ReadLine();
    //    }
    //    public static void Foo(double x)
    //    {
    //        Console.WriteLine("double parameters");
    //    }

    //    static void Foo(int x, int y = 0)
    //    {
    //        Console.WriteLine("optional parameters");
    //    }
    //    static void Foo(string x , int y=0)
    //    {
    //        Console.WriteLine("optional parameters");
    //    }
    //    static void Foo(object x)
    //    {
    //        Console.WriteLine("object");
    //    }
    //    static void Foo(string x)
    //    {
    //        Console.WriteLine("string");
    //    }
    //    //static int Foo(string x)
    //    //{
    //    //    Console.WriteLine("string");
    //    //    return 1;
    //    //}

    //    //static void Foo<T>(params T[] x)
    //    //{
    //    //    Console.WriteLine("params T[]");
    //    //}
    //} 
}
