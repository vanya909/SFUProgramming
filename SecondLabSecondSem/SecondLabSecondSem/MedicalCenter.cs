using System;

namespace SecondLabSecondSem
{
    delegate void AlarmHandler(object sender, AlarmEventArgs e);

    class MedicalCenter
    {
        public event AlarmHandler Alarm;

        public void OnAlarm(Student student, Institute institute)
        {
            student.IsStudyDistance = true;
            Alarm(this, new AlarmEventArgs(student, institute));
        }
    }

    class AlarmEventArgs : EventArgs
    {
        public string InstituteName { get; set; }
        public string GroupName { get; set;}
        public string StudentName { get; set;}

        public AlarmEventArgs(Student student, Institute institute)
        {
            InstituteName = institute.GetType().Name;
            GroupName = student.GroupName;
            StudentName = student.Name;
        }
    }
}
