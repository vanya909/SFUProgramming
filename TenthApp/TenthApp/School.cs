using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenthApp
{
    class School
    {
        public List<Student> students { get; set; } = new List<Student>();

        public (Student, Student) FindMinMaxEmployee()
        {
            students.Sort();
            return (students[students.Count - 1], students[0]);
        }

        public void Reward()
        {
            Student goodStudent = FindMinMaxEmployee().Item1;
            Student badStudent = FindMinMaxEmployee().Item2;

            goodStudent.CountLunch += badStudent.CountLunch;
            badStudent.CountLunch = 0;
        }
    }
}
