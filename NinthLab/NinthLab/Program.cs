using System;

namespace NinthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkpoint c = new Checkpoint();
            Human.Student student = new Human.Student() { IsHaveQR = true, IsHaveMask = false, Name = "Петя" };
            Human.Teacher teacher = new Human.Teacher() { IsHaveQR = true, Name = "Алексей Викторович" };
            Human.Enrollee enrollee = new Human.Enrollee() { IsHaveQR = false, Name = "Саня" };

            Animal.Dog dog = new Animal.Dog() { IsHaveMask = true, Name = "asdasd" };
            Animal.Dove dove = new Animal.Dove();
            Animal.Squirrel squirrel = new Animal.Squirrel();

            Console.WriteLine($"{c.MaskCount} - {c.DesinfectCount}");

            c.VisitorsWantToISIT.Add(student);
            c.VisitorsWantToISIT.Add(teacher);
            c.VisitorsWantToISIT.Add(enrollee);

            c.VisitorsWantToISIT.Add(dog);
            c.VisitorsWantToISIT.Add(dove);
            c.VisitorsWantToISIT.Add(squirrel);

            c.Check();

            Console.WriteLine("Хотят:");
            foreach (IVisitor v in c.VisitorsWantToISIT)
                Console.WriteLine(((IVisitor)v).Name);

            Console.WriteLine("\nМогут:");
            foreach (IVisitor v in c.VisitorsCanToISIT)
                Console.WriteLine(((IVisitor)v).Name);

            Console.WriteLine($"{c.MaskCount} - {c.DesinfectCount}");
        }
    }
}
