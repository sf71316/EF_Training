using System;
using System.Collections.Generic;
using System.Data.Entity;
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

            #region Trainnig Select
            //using (var db = new ContosoUniversityEntities())
            //{
            //    foreach (var item in db.Course)
            //    {
            //        Console.WriteLine(item.Title);
            //    }
            //    Console.WriteLine();
            //    foreach (var item in db.Department)
            //    {
            //        Console.WriteLine(item.Name);
            //        foreach (var c in item.Course)
            //        {
            //            Console.WriteLine("\t" + c.Credits);
            //        }
            //    }
            //}
            #endregion

            #region Trainnig Update
            //using (var db = new ContosoUniversityEntities())
            //{
            //    foreach (var item in db.Course)
            //    {
            //        item.Title += "!";
            //    }
            //    db.SaveChanges();
            //}
            #endregion

            #region Trainnig Insert
            //using (var db = new ContosoUniversityEntities())
            //{
            //    db.Course.Add(new Course
            //    {
            //        Title = "Entity Framework 1",
            //        Credits = 1,
            //        DepartmentID = 2
            //    });
            //    db.Course.Add(new Course
            //    {
            //        Title = "Entity Framework 6",
            //        Credits = 1,
            //        Department = db.Department.Find(1)
            //    });
            //    db.SaveChanges();
            //}
            #endregion

            #region Trainnig Delete
            //using (var db = new ContosoUniversityEntities())
            //{
            //    db.Course.Remove(db.Course.FirstOrDefault(p => p.CourseID == 11));
            //    db.Course.Remove(db.Course.Find(10));
            //    db.SaveChanges();
            //}
            #endregion

            #region Trainnig RunSQL
            //using (var db = new ContosoUniversityEntities())
            //{
            //    db.Database.ExecuteSqlCommand("DELETE FROM dbo.Course WHERE CourseID=@ID",
            //        new SqlParameter("@ID", 7));
            //    var person = db.Database.SqlQuery<Person>("SELECT top 10 * FROM Person where ID >@p0 ", 1);
            //    foreach (var item in person)
            //    {
            //        Console.WriteLine(item.FirstName);
            //    }
            //}
            #endregion

            #region Trainning Get Entity Status
            //using (var db = new ContosoUniversityEntities())
            //{
            //    var c = db.Course.Find(2);

            //    Console.WriteLine("Status:" + db.Entry(c).State);
            //    c.Title = "Git新手入門";
            //    Console.WriteLine("Status:" + db.Entry(c).State);
            //    db.Course.Remove(c);
            //    Console.WriteLine("Status:" + db.Entry(c).State);
            //}
            #endregion

            #region Trainning jude Entity Status & process (save createdon & modifiedon)
            //using (var db = new ContosoUniversityEntities())
            //{
            //    db.Course.Add(new Course
            //    {
            //        Title = "Class 1",
            //        Credits = 2,
            //        DepartmentID = 1
            //    });
            //    var c = db.Course.Find(2);
            //    c.Title = "Git新手入門!!!!!!";
            //    db.SaveChanges();
            //}
            #endregion

            #region Trainning offline object modified to other db context
            //Course c;
            //using (var db = new ContosoUniversityEntities())
            //{
            //    c = db.Course.Find(2);
            //    c.Title = "Git新手入門";
            //}
            //using (var db = new ContosoUniversityEntities())
            //{
            //    db.Entry(c).State = EntityState.Modified;
            //    db.SaveChanges();
            //}
            //#endregion

            //#region Trainning Concurrency Mode
            //using (var db = new ContosoUniversityEntities())
            //{
            //    var cc = db.GetCourse(1);
            //    foreach (var item in cc)
            //    {
            //        Console.WriteLine(item.Title);
            //    }
            //}
            #endregion

            #region Usaged Enum
            using (var db = new ContosoUniversityEntities())
            {
                db.Course.Add(new Course
                {
                    Title = "Class 6",
                    Credits = CourseCredits.Level2,
                    DepartmentID = 1
                });
                db.SaveChanges();
            }
            #endregion
        }
    }
}
