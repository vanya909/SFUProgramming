using System;

namespace TenthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            School school = new School();

            for (int i = 0; i < 1000000; i++)
            {
                school.students.Add(new Student()
                {
                    Number = i,
                    CountPhone = i % 21,
                    CountLunch = 5,
                    Position = (Position)(i % 3)
                }) ;
            }

            school.Reward();
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalSeconds);
        }
    }


    struct Student : IComparable
    {
        public int Number { get; set; }
        public int CountPhone { get; set; }
        public int CountLunch { get; set; }

        public Position Position { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is Student)
            {
                Student student = (Student)obj;
                int difference = this.CountPhone - student.CountPhone;

                return difference == 0 ? this.Position.CompareTo(student.Position) : difference;
            }
            else throw new ArgumentException("Must be Student!");
        }
    }


    //class Student : IComparable
    //{
    //    public int Number { get; set; }
    //    public int CountPhone { get; set; }
    //    public int CountLunch { get; set; }

    //    public Position Position { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        if (obj == null) return 1;
    //        if (obj is Student)
    //        {
    //            Student student = (Student)obj;
    //            int difference = this.CountPhone - student.CountPhone;

    //            return difference == 0 ? this.Position.CompareTo(student.Position) : difference;
    //        }
    //        else throw new ArgumentException("Must be Student!");
    //    }
    //}


    enum Position
    {
        HIGH,
        JUNIOR,
        PRE
    }
}
