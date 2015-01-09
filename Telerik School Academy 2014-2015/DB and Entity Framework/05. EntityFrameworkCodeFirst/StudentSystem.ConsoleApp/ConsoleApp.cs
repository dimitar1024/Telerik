
using System;
using System.Collections.Generic;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Model;

using StudentSystem.Model.cs;

namespace StudentSystem.ConsoleApp
{
    public class ConsoleApp
    {
        public static void Main() 
        {
            var db = new StudentSystemDbContext();

            var student = new Student()
            {
                FirstName = "Kancho",
                LastName = "Angelov",
                Phone = "4388887181",
                Address = "Vasil Levski 9412",
                Email = "kanchoangelov@abv.bg",
                
            };

            var course = new Course();
            course.Name = "Entity Framework Code First";
            course.Description = "Entity Framework supports three types of modeling workflow";

            var homework = new Homework()
            {
                Content = "Write the program...",
                DateOfSending = DateTime.Parse("2015-01-10")
            };

            db.Homeworks.Add(homework);
            db.Courses.Add(course);
            db.Students.Add(student);
            db.SaveChanges();


            var save = db.Students.First();

            Console.WriteLine(save.StudentId +": "+ save.FirstName + " " + save.LastName);
            
        }

    }
}
