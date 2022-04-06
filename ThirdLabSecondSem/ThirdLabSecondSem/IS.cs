namespace ThirdLabSecondSem
{
    internal class IS
    {
        public static List<Teacher> Teachers = new List<Teacher>();
        delegate bool IsCanAddTeacher(string name);

        /* Проходим по массиву всех преподавателей,
           сравниваем FIO с переданным параметром name и смотрим равно ли количество совпадений нулю.
           Если да, то можем добавить нового преподавателя */
        private static IsCanAddTeacher isCanAddTeacher = (name) => (from t in Teachers
                                                                    where t.FIO.ToLower() == name.ToLower()
                                                                    select t).Count() == 0;

        public static void AddTeacher(string fio, string institute, string service)
        {
            if (isCanAddTeacher(fio))
                Teachers.Add(new Teacher() { FIO = fio, Institute = institute, Service = service });
        }

        /* Создаём группы по сервисам преподавателей,
           на основе каждой группы создаём объект TopServices(имя_сервиса, количество_преподавателей_использующих_сервис),
           сортируем в порядке убывания по количеству использований сервиса,
           берём только первые три и преобразуем в List */
        public static List<TopServices> TOP() => new List<TopServices>(Teachers
                                                                       .GroupBy(x => x.Service)
                                                                       .Select(g => new TopServices(g.Key, g.Count()))
                                                                       .OrderByDescending(g => g.Count)
                                                                       .Take(3)
                                                                       .ToList());

        public static string GetShortName(Teacher teacher)
        {
            var firstName = teacher.FIO.Split(' ')[0]; // Разбиваем полное имя по пробелам

            /* Разбиваем имя по пробелам снова,
               берём только последние два элемента массива (имя и отчество),
               далее берём только первые буквы имени и отчества,
               переводим их в верхний регистр и склеиваем обратно в строку */
            var initials = string.Join(' ', teacher.FIO
                                            .Split(' ')[1..]
                                            .Select(n => n[0] + ".")
                                            .Select(n => n.ToUpper()));

            return $"{firstName} {initials}";
        }
    }
}
