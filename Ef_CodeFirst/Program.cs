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
                var std = new Standard
                {
                    StandardId = 1,
                    StandardName = "Level1"
                };
                std.Students.Add(new Student { 
                 StudentID=1,
                 StudentName="ABC",
                 Height=170,
                 Weight=50
                });
                std.Students.Add(new Student
                {
                    StudentID = 2,
                    StudentName = "DEF",
                    Height = 190,
                    Weight = 80
                });
                db.Standards.Add(std);
                db.SaveChanges();

                foreach (var item in db.Standards)
                {
                    Console.WriteLine(item.StandardId+"\t"+item.StandardName);   
                }
            }
        }
    }
}
