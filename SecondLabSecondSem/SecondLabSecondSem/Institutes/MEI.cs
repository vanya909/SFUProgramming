using System;
using System.Collections.Generic;

namespace SecondLabSecondSem
{
    class MEI : Institute
    {
        public override void MedicalCenter_Alarm(object sender, AlarmEventArgs e)
        {
            if (e.InstituteName == "MEI")
                TransferInstituteToDistant();
        }

        private void TransferInstituteToDistant()
        {
            Console.WriteLine($"ВИ уходит на дистант");
            foreach (Student student in Students)
                    student.IsStudyDistance = true;
        }

        public MEI()
        {
            Students = new List<Student>();
        }
    }
}
