using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FifthLabSecondSem.Domain
{
    internal class Subject : INotifyPropertyChanged
    {
        public Subject()
        {
        }
        public Subject(String name)
        {
            this.Name = name;
            this.Status = false;
        }
        public Subject(String name, bool status)
        {
            this.Name = name;
            this.Status = status;
        }
        public String Name { 
            get { return _name; }
            set 
            { 
                _name = value;
                NotifyPropertyChanged();
            }
        }
        public bool Status 
        { 
            get { return _status; }
            set
            {
                _status = value;
                NotifyPropertyChanged();
            }
        }
        private bool _status;
        private string _name;

        public event PropertyChangedEventHandler? PropertyChanged;
        public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
