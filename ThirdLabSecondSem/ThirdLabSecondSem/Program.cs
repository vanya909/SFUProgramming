namespace ThirdLabSecondSem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Добавление преподавателей
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
            {
                Console.Write($"{IS.GetShortName(teacher)} - {teacher.Institute} - ");
                Console.ForegroundColor = getColor(teacher.Service);
                Console.WriteLine(teacher.Service);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();

            foreach (var item in IS.TOP())
            {
                Console.ForegroundColor = getColor(item.Service);
                Console.Write($"{item.Service} - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(item.Count);
            }
                
        }

        /* Получаем цвет текста в консоле на основе хэш кода строки 
          (цвет будет каждый раз разный, правда иногда он может быть таким же, как цвет консоли) */
        static ConsoleColor getColor(string service)
        {
            return (ConsoleColor)(Math.Abs(service.GetHashCode()) % 15);
        }
    }
}

