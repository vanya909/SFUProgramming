namespace ThirdLabSecondSem
{
    internal class IS
    {
        public static List<Teacher> Teachers = new List<Teacher>();
        delegate bool IsCanAddTeacher(string name);
        private static IsCanAddTeacher isCanAddTeacher = (name) => (from t in Teachers
                                                                    where t.FIO.ToLower() == name.ToLower()
                                                                    select t).Count() == 0;

        public static void AddTeacher(string fio, string institute, string service)
        {
            if (isCanAddTeacher(fio))
                Teachers.Add(new Teacher() { FIO = fio, Institute = institute, Service = service });
        }

        public static List<TopServices> TOP() => new List<TopServices>(Teachers
                                                                       .GroupBy(x => x.Service)
                                                                       .Select(g => new TopServices(g.Key, g.Count()))
                                                                       .OrderByDescending(g => g.Count)
                                                                       .Take(3)
                                                                       .ToList());

        public static string GetShortName(Teacher teacher)
        {
            var firstName = teacher.FIO.Split(' ')[0];
            var initials = string.Join(' ', teacher.FIO
                                            .Split(' ')[1..]
                                            .Select(n => n[0] + ".")
                                            .Select(n => n.ToUpper()));

            return $"{firstName} {initials}";
        }
    }
}
