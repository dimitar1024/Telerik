﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StudentSystem.Model.cs;

namespace StudentSystem.Model.cs
{
    public class Homework
    {
        public int HomeworkId { get; set; }

        public string Content { get; set; }

        public DateTime DateOfSending { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
