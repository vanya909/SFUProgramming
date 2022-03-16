using System;
using System.Collections.Generic;

namespace SecondLabSecondSem
{
    class IKIT : Institute
    {
        public override void MedicalCenter_Alarm(object sender, AlarmEventArgs e)
        {
            if (e.InstituteName == "IKIT")
                TransferGroupToDistant(e.GroupName);
        }

        private void TransferGroupToDistant(string groupName)
        {
            Console.WriteLine($"Группа {groupName} ИКИТа уходит на дистант");
            foreach (Student student in Students)
            {
                if (student.GroupName == groupName)
                    student.IsStudyDistance = true;
            }
        }

        public IKIT()
        {
            Students = new List<Student>();
        }
    }
}
