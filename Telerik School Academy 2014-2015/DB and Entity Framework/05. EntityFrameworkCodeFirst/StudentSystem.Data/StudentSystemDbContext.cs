namespace StudentSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.Model.cs;
    using StudentSystem.cs;

    public class StudentSystemDbContext : DbContext
    {
        public IDbSet<Student> Students { set; get; }

        public IDbSet<Homework> Homeworks { set; get; }

        public IDbSet<Course> Courses { set; get; }

        public IDbSet<Material> Materials { set; get; } 
    }
}
