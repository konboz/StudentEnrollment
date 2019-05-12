using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task2Sol
{
    class Course
    {
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public string Code { get; private set; }

        public Course(string code, string name)
        {
            Code = code;
            CourseName = name;
        }

        public Course()
        {
            CourseName = "No course enrolled";
        }


    }
}
