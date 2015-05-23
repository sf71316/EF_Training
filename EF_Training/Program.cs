using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Training_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db =new ContosoUniversityEntities())
            {
                #region Trainig Select
                //foreach (var item in db.Course)
                //{
                //    Console.WriteLine(item.Title);
                //}
                //Console.WriteLine();
                //foreach (var item in db.Department)
                //{
                //    Console.WriteLine(item.Name);
                //    foreach (var c in item.Course)
                //    {
                //        Console.WriteLine("\t"+c.Credits);
                //    }
                //}
                #endregion

                #region Training Update
                //foreach (var item in db.Course)
                //{
                //    item.Title += "!";
                //}
                //db.SaveChanges();
                #endregion

                #region Training Insert
                //db.Course.Add(new Course { 
                //    Title="Entity Framework 1",
                //    Credits=1,
                //    DepartmentID=2
                //});
                //db.Course.Add(new Course
                //{
                //    Title = "Entity Framework 6",
                //    Credits = 1,
                //    Department = db.Department.Find(1)
                //});
                //db.SaveChanges();
                #endregion

                #region Training Delete
               // db.Course.Remove(db.Course.FirstOrDefault(p => p.CourseID == 11));
               //// db.Course.Remove(db.Course.Find(10));
               // db.SaveChanges();
                #endregion

                #region Training RunSQL
                
                //db.Database.ExecuteSqlCommand("DELETE FROM dbo.Course WHERE CourseID=@ID",
                //    new SqlParameter("@ID",7));
                var person = db.Database.SqlQuery<Person>("SELECT top 10 * FROM Person ", new SqlParameter("@ID",1));
                foreach (var item in person)
                {
                    Console.WriteLine(item.FirstName);
                }
                #endregion
            }
        }
    }
}
