﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Trainnig
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db =new ContosoUniversityEntities())
            {
                #region Trainnig Select
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

                #region Trainnig Update
                //foreach (var item in db.Course)
                //{
                //    item.Title += "!";
                //}
                //db.SaveChanges();
                #endregion

                #region Trainnig Insert
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

                #region Trainnig Delete
               // db.Course.Remove(db.Course.FirstOrDefault(p => p.CourseID == 11));
               //// db.Course.Remove(db.Course.Find(10));
               // db.SaveChanges();
                #endregion

                #region Trainnig RunSQL
                
                //db.Database.ExecuteSqlCommand("DELETE FROM dbo.Course WHERE CourseID=@ID",
                //    new SqlParameter("@ID",7));
                var person = db.Database.SqlQuery<Person>("SELECT top 10 * FROM Person where ID >@p0 ", 1);
                foreach (var item in person)
                {
                    Console.WriteLine(item.FirstName);
                }
                #endregion
            }
        }
    }
}
