using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lazy_Type
{
    public class Student
    {
        public int Id { get; set; }
        public Student()
        {
            //Thread.Sleep(5000);
        }
        public Student(int id)
        {
            Id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lazyStudent = new Lazy<Student>(LazyThreadSafetyMode.ExecutionAndPublication);
            //alternatively, you can use false instead of LazyThreadSafetyMode.None
            //var lazyStudent = new Lazy<Student>(false);
            var students = new ConcurrentBag<Task<Student>>();
            Task.Run(() =>
            {
                Parallel.For(0, 2, i =>
                {
                    students.Add(Task.Run(() => lazyStudent.Value));
                });
            }).Wait();
            var areEqual = object.ReferenceEquals(students.First().Result, students.Last().Result);
            //Assert.True(areEqual);
        }
    }
}
