using System;
using System.Collections.Generic;

namespace SecondLabSecondSem
{
    class HI : Institute
    {
        public override void MedicalCenter_Alarm(object sender, AlarmEventArgs e)
        {
            TransferInstituteToDistant();
        }

        private void TransferInstituteToDistant()
        {
            Console.WriteLine($"ГИ уходит на дистант");
            foreach (Student student in Students)
                student.IsStudyDistance = true;
        }

        public HI()
        {
            Students = new List<Student>();
        }
    }
}
