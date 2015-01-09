using System;
using System.Collections.Generic;
using System.Linq;

using StudentSystem.Model.cs;


namespace StudentSystem.cs
{
    public class Material
    {
        
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateOfPost { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
