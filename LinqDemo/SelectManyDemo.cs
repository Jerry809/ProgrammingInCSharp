using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class SelectManyDemo
    {
        public void Run() 
        {
            List<Student3> t = new List<Student3>()
            {
                new Student3()
                {
                    Id = 1,
                    Name = "Miles",
                    Course = new List<Course2>() 
                    { 
                        new Course2(){
                        StudentId = 1,
                        CourseName = "數學"
                        },
                        new Course2(){
                        StudentId = 1,
                        CourseName = "國文"
                        },
                    }
                },
                new Student3()
                {
                    Id = 2,
                    Name = "Bob",
                    Course = new List<Course2>()
                    {
                        new Course2(){
                            StudentId = 2,
                            CourseName = "數學"
                        }
                    }
                }
            };

            var data = t.SelectMany(
                    // 第一個參數，代表每一筆Student各包含哪些Course
                    std => std.Course, 
                    // 第二個參數，則是產生新的匿名型別
                    (std, crs) => new { std.Id, std.Name, crs.CourseName }
                    );

            foreach (var item in data)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.CourseName);
            }

        }

        class Student3
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<Course2> Course { get; set; }
        }


    }
}
