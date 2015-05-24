using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db =new SchoolContext())
            {
                //var std = new Standard
                //{
                //    StandardId = 2,
                //    StandardName = "Level2"
                //};
                //std.Students.Add(new Student { 
                // StudentID=3,
                // StudentName="ABC2",
                // Height=170,
                // Weight=50
                //});
                //std.Students.Add(new Student
                //{
                //    StudentID = 4,
                //    StudentName = "DEF2",
                //    Height = 190,
                //    Weight = 80
                //});
                //db.Standards.Add(std);
                //db.SaveChanges();

                foreach (var item in db.Standards)
                {
                    Console.WriteLine(item.StandardId+"\t"+item.StandardName);
                    foreach (var p in item.Students)
                    {
                        Console.WriteLine("\t"+p.StudentID+"\t"+p.StudentName);
                    }
                }
            }
        }
    }
}
