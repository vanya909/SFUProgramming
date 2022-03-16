using System;

namespace SecondLabSecondSem
{
    class Program
    {
        static void Main(string[] args)
        {
            MedicalCenter medicalCenter = new MedicalCenter();
            IKIT ikit = new IKIT();
            HI hi = new HI();
            MEI mei = new MEI();

            medicalCenter.Alarm += ikit.MedicalCenter_Alarm;
            medicalCenter.Alarm += hi.MedicalCenter_Alarm;
            medicalCenter.Alarm += mei.MedicalCenter_Alarm;

            Student anatoliy = new Student()
            {
                Name = "Анатолий",
                GroupName = "КИ-01"
            };
            Student petruha = new Student()
            {
                Name = "Петруха",
                GroupName = "ВОЕН-01"
            };
            Student vanuha = new Student()
            {
                Name = "Ванюха",
                GroupName = "ГУМ-01"
            };

            ikit.Students.Add(anatoliy);
            mei.Students.Add(petruha);
            hi.Students.Add(vanuha);


            medicalCenter.OnAlarm(anatoliy, ikit);
            Console.WriteLine("-----");
            Console.WriteLine();

            medicalCenter.OnAlarm(petruha, mei);
            Console.WriteLine("-----");
            Console.WriteLine();

            medicalCenter.OnAlarm(vanuha, hi);
            Console.WriteLine("-----");
            Console.WriteLine();
        }

        private static void AddStudents()
        {

        }
    }
}
