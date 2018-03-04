using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_out_top_25_Percent_of_the_students
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 and 2: Load Student data
        ClassReport cr1 = MockSem1();
        ClassReport cr2 = MockSem2();
        var results = from sem1 in cr1.Students
                      join sem2 in cr2.Students on sem1.Id equals sem2.Id
                      select new { sem1.Id, sem1.Name, G1 = sem1.Grade, G2 = sem2.Grade, diff = (sem2.Grade - sem1.Grade) };
        var res2 = from res in results
                   group res by res.G2 into g   
                   let firstRecord=g.FirstOrDefault()
                   let ID=firstRecord.Id
                   let Name=firstRecord.Name
                   let diff=firstRecord.diff
                   let sum = g.Sum(x => x.diff)
                   select new {sum=sum, Id=ID, Name=Name,Percetage=(diff*100)/sum};
        
        }
        private static ClassReport MockSem1()
        {
            ClassReport cr = new ClassReport()
            {
                Id = 1,
                Name = "First Grade",
                SemesterId = 1
            };

            // add dummy data - in real life, this comes from database
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 1,
                    Name = "Ray",
                    Grade = 90
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 2,
                    Name = "Jack",
                    Grade = 80
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 3,
                    Name = "John",
                    Grade = 60
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 4,
                    Name = "Lisa",
                    Grade = 67
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 5,
                    Name = "Jill",
                    Grade = 94
                });
            return cr;
        }

        private static ClassReport MockSem2()
        {
            ClassReport cr = new ClassReport()
            {
                Id = 1,
                Name = "First Grade",
                SemesterId = 2
            };

            // add dummy data - in real life, this comes from database
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 1,
                    Name = "Ray",
                    Grade = 85
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 2,
                    Name = "Jack",
                    Grade = 95
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 3,
                    Name = "John",
                    Grade = 82
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 4,
                    Name = "Lisa",
                    Grade = 95
                });
            cr.Students.Add(
                new StudentRecord()
                {
                    Id = 5,
                    Name = "Jill",
                    Grade = 96
                });
            return cr;
        }
    }

    public class StudentRecord
    {
        // basic properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        // computational properties
        public double GradeSecondSemester { get; set; }
        public double GradeDifference { get; set; }
        public double GradeDifferencePercent { get; set; }
    }
    public class ClassReport
    {
        // some basic properties of a class
        public int Id { get; set; }
        public string Name { get; set; }
        public int SemesterId { get; set; }

        // list of student records for that semester
        public List<StudentRecord> Students;

        public ClassReport()
        {
            Students = new List<StudentRecord>();
        }
    }

}
