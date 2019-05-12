using System;

namespace Home_task2Sol
{


    class Program
    {
        static void Main(string[] args)
        {
            var math = new Course("M01", "Math 01");
            var physics = new Course("P01", "Physics 01");
            var kostas = new Student();
            kostas.Name = "kostas";
            kostas.Level = LevelId.FirstGrade;
            kostas.Age = 25;
            kostas.EnrollToCourse(physics);
            kostas.Grade = Student.CalculateMark(78);
            Console.WriteLine(kostas);

            kostas.WithdrawFromCourse();
            Console.WriteLine(kostas);

            Console.ReadLine();
        }
    }
}
