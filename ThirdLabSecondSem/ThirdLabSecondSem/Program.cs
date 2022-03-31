namespace ThirdLabSecondSem
{
    class Program
    {
        static void Main(string[] args)
        {
            IS.AddTeacher("Петров Петр Петрович", "ИКИТ", "Zoom");
            IS.AddTeacher("Иванов Иван Иванович", "ИКИТ", "Zoom");
            IS.AddTeacher("Паранов Иван Лаврентьевич", "ИКИТ", "Zoom");

            IS.AddTeacher("Абрикосов Абрикос Терентьевич", "ИКИТ", "Google Meet");
            IS.AddTeacher("Оаоаов Оаоа Оаоаович", "ИКИТ", "Google Meet");
            IS.AddTeacher("Лавров Лавр Лаврович", "ИКИТ", "Google Meet");
            IS.AddTeacher("Лавров Лавр Лаврович", "ИКИТ", "Google Meet"); // Дублирование преподавателя

            IS.AddTeacher("ФИС Петр ФИС", "ИКИТ", "Другое");
            IS.AddTeacher("ФИС Иван ФИС", "ИКИТ", "Другое");

            IS.AddTeacher("AAasad a a", "ИКИТ", "Совсем другое");


            foreach (var teacher in IS.Teachers)
                Console.WriteLine($"{IS.GetShortName(teacher)} - {teacher.Institute} - {teacher.Service}");

            Console.WriteLine();

            foreach (var item in IS.TOP())
                Console.WriteLine(item);
        }
    }
}

