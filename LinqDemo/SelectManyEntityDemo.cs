using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class SelectManyEntityDemo
    {        
        public void RunJoin() 
        {
            LinqDemoEntities db = new LinqDemoEntities();

            var data = db.Student
                         .Join(
                                db.Course,              //跟Course LEFT JOIN
                                std => std.Id,          //Student 對應Course Key 值為 Id
                                crs => crs.SutdentId,   //Course 對應Student Key 值為SutdentId
                                (std, crs) => new { 
                                                    std.Id,        //輸出學生Id
                                                    std.Name,      //輸出學生姓名
                                                    crs.CourseName //輸出課程名稱
                                                  }
                               );

        }

        public void Run() 
        {
            LinqDemoEntities db = new LinqDemoEntities();
            var data = db.Student.SelectMany(x => x.Course.DefaultIfEmpty());

            foreach (var item in data)
            {
                Console.WriteLine(item.CourseName);
            }
            Console.WriteLine("hi");
        }

        public void Run2()
        {
            LinqDemoEntities db = new LinqDemoEntities();
            var data = db.Student
                         .GroupJoin(
                                        db.Course,
                                        std => std.Id,
                                        crs => crs.SutdentId,
                                        (std, crs) => new { std.Id, std.Name, crs = crs }
                                    )
                         .SelectMany(
                                        x => x.crs.DefaultIfEmpty(),    //要使用DefaultIfEmpty，才能轉換成Left Join
                                        (std, crs) => new 
                                                      { 
                                                          std.Id,           //輸出Student Id
                                                          std.Name,         //輸出Student Name
                                                          crs.CourseName    //輸出Course CourseName
                                                      }
                                    );

            foreach (var item in data)
            {                
                Console.WriteLine(item.Id);
            }
        }
    }
}
