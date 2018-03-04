using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    /// <summary>
    /// Class is refernce type.If we create copy of class instance it always points to a single object
    /// Struct is a vlue type if we create a copy of struct instance it altogther a new copy
    /// </summary>
    class Test 
    {
        public string MyProperty { get; set; }
    }
    struct TestStruct
    {
        public string MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1=new Test();
            t1.MyProperty="class Test Output1";
            Test t2=t1;
            t2.MyProperty = "classs Test Output2";
            Console.WriteLine(t1.MyProperty);
            Console.ReadLine();
            TestStruct ts1 = new TestStruct();
            ts1.MyProperty = "struct Test Output1";
            TestStruct ts2 = ts1;
            ts2.MyProperty = "struct Test Output2";
            Console.WriteLine(ts1.MyProperty);
            Console.ReadLine();
        }
    }
}
