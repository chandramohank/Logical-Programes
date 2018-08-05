using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Programes
{
    public class Person
    {
        public  const double TestVaribale = 3.0;
        public string Name { get; set; }

        public static readonly int readonlyvariable ;
        
        public Person() { }

        //Person(int x) 
        //{
        //    //Error	2	A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)

        //    //readonlyvariable=x
        //}
        static Person()
        {
            //Static constructor must be parameter less
            readonlyvariable = 10;
            Console.WriteLine("static constructor varible value" + readonlyvariable);
        }
    }

    public static class Employee
    {
        public  const int TestVaribale = 3;
    }
    public struct SPerson
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "P1 name";
            Person p2 = new Person();
            p2.Name = "P2 name";
            SPerson s1 = new SPerson();
            SPerson s2 = new SPerson();
            bool b = (p1 == p2);
            Console.WriteLine(b);//false

            //bool c = (s1 == s2);  /*Compile error .struct type variable cannot be comparable*/

            Person p3 = p2;
            Console.WriteLine(String.Format("P1 and P2 Equal?{0}; P1.Name : {1} ;P2.Name : {2}", b, p1.Name, p2.Name));
            p3.Name = "P3 name";
            bool d = (p3 == p2);//true

            Console.WriteLine(String.Format("P3 and P2 Equal?{0}; P2.Name : {1} ;P3.Name : {2}", d, p2.Name, p3.Name));
            Console.WriteLine(d);
            Console.ReadLine();



            //Constant always a statc
            Console.WriteLine(Person.TestVaribale);
            Console.WriteLine(Employee.TestVaribale);
            Console.ReadLine();
        }
    }
}
