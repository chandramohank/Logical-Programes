using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public string testVariable = "test VAribale1";
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.Instance;
           
            Singleton instance2 = Singleton.Instance;
            instance.testVariable="t2";
            Console.WriteLine(instance.testVariable);

        }
    }
}
