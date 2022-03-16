using System.Collections.Generic;

namespace SecondLabSecondSem
{
    abstract class Institute
    {
        public List<Student> Students;
        public abstract void MedicalCenter_Alarm(object sender, AlarmEventArgs args);
    }
}
