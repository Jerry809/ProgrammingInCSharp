using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectManyDemo s = new SelectManyDemo();
            //s.Run();
            SelectManyEntityDemo se = new SelectManyEntityDemo();
            //se.Run();
            se.Run2();
            //se.RunJoin();
            
            //LeftJoinRun();


        }

        private static void LeftJoinRun()
        {

            var students = GetSudents();

            var courses = GetCourses();

            var result = students.GroupJoin(courses,
                std => std.Id,
                crs => crs.StudentId,
                (s, c) => new { Id = s.Id, Name = s.Name, Crs = c }).ToList()

                .SelectMany(
                x => x.Crs.DefaultIfEmpty(),
                (x, y) => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Crs = y.CourseName
                });

            foreach (var item in result)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Crs);
            }
        }

        private static List<Student2> GetSudents()
        {
            return new List<Student2>()
            {
                new Student2(){
                    Id = 1,
                    Name = "Miles"
                },
                new Student2(){
                    Id = 2,
                    Name = "Bob"
                }
            };
        }

        private static List<Course2> GetCourses() 
        {
            return new List<Course2>()
            {
                new Course2(){
                    StudentId = 1,
                    CourseName = "數學"
                },
                new Course2(){
                    StudentId = 1,
                    CourseName = "國文"
                },
                new Course2(){
                    StudentId = 1,
                    CourseName = "英文"
                }
            };
        }

    }

    class Student2
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }

    class Course2
    {
        public int StudentId { get; set; }        
        public string CourseName { get; set; }
    }
}
