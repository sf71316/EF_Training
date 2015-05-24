﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Trainnig
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ContosoUniversityEntities : DbContext
    {
        public ContosoUniversityEntities()
            : base("name=ContosoUniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<vwCourseDep> vwCourseDep { get; set; }
    
        public virtual int Department_Delete(Nullable<int> departmentID, byte[] rowVersion_Original)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var rowVersion_OriginalParameter = rowVersion_Original != null ?
                new ObjectParameter("RowVersion_Original", rowVersion_Original) :
                new ObjectParameter("RowVersion_Original", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Department_Delete", departmentIDParameter, rowVersion_OriginalParameter);
        }
    
        public virtual ObjectResult<Department_Insert_Result> Department_Insert(string name, Nullable<decimal> budget, Nullable<System.DateTime> startDate, Nullable<int> instructorID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var budgetParameter = budget.HasValue ?
                new ObjectParameter("Budget", budget) :
                new ObjectParameter("Budget", typeof(decimal));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department_Insert_Result>("Department_Insert", nameParameter, budgetParameter, startDateParameter, instructorIDParameter);
        }
    
        public virtual ObjectResult<byte[]> Department_Update(Nullable<int> departmentID, string name, Nullable<decimal> budget, Nullable<System.DateTime> startDate, Nullable<int> instructorID, byte[] rowVersion_Original)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var budgetParameter = budget.HasValue ?
                new ObjectParameter("Budget", budget) :
                new ObjectParameter("Budget", typeof(decimal));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            var rowVersion_OriginalParameter = rowVersion_Original != null ?
                new ObjectParameter("RowVersion_Original", rowVersion_Original) :
                new ObjectParameter("RowVersion_Original", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("Department_Update", departmentIDParameter, nameParameter, budgetParameter, startDateParameter, instructorIDParameter, rowVersion_OriginalParameter);
        }
    
        public virtual ObjectResult<Course> GetCourse(Nullable<int> credits)
        {
            var creditsParameter = credits.HasValue ?
                new ObjectParameter("Credits", credits) :
                new ObjectParameter("Credits", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourse", creditsParameter);
        }
    
        public virtual ObjectResult<Course> GetCourse(Nullable<int> credits, MergeOption mergeOption)
        {
            var creditsParameter = credits.HasValue ?
                new ObjectParameter("Credits", credits) :
                new ObjectParameter("Credits", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourse", mergeOption, creditsParameter);
        }
    }
}
