using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task2Sol
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public LevelId Level { get; set; }
        private Course EnrolledCourse { get; set; }
        public string Grade { get; set; }

        public Student()
        {
        }

        public void EnrollToCourse(Course course)
        {
            if (EnrolledCourse == null && Age >= 18)
            {
                EnrolledCourse = course;

            }
            else
            {
                Console.WriteLine("You can't yet enroll to a course");
            }
        }

        public void WithdrawFromCourse()
        {
            EnrolledCourse = null;
        }

        public static string CalculateMark(int mark)
        {
            string Grade;
            if (mark <= 100 && mark >= 90)
            {
                Grade = "A";
            }
            else if (mark <= 89 && mark >= 70)
            {
                Grade = "B";
            }
            else if (mark <= 69 && mark >= 50)
            {
                Grade = "C";
            }
            else if (mark <= 50 && mark >= 0)
            {
                Grade = "F";
            }
            else
            {
                return "Wrong mark";
            }
            return Grade;
        }

        public override string ToString()
        {
            if (EnrolledCourse == null)
            {
                return $"Name: {Name}, age: {Age}, course: No enrolled course";
            }
            else
            {
                return $"Name: {Name}, age: {Age}, course: {EnrolledCourse.CourseName}, grade: {Grade}";
            }

        }
    }
}
