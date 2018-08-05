using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctWithInterfcae
{
    //Do i need to implement in the derived classs which already has refrence to interface in Base

    public interface IBase
    {
        void Display();
    }

    public abstract class Base : IBase
    {        
        public void Display()
        {
            Console.WriteLine("Base Display");
        }
    }


    public class child1 : Base
    {
        public new void Display()
        {
            Console.WriteLine("child1 Display");
        }
    }

    public class child2 : Base,IBase
    {     
        public new void Display()
        {
            Console.WriteLine("child2 Display");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBase obj = new child1();
            obj.Display(); // writing Base display
            IBase obj2 = new child2();
            obj2.Display(); //Wrirting child2 dispaly
            Console.ReadLine();
        }
    }
}
