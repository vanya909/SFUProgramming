using FifthLabSecondSem.Domain;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace FifthLabSecondSem
{
    internal class Logics : INotifyPropertyChanged
    {
        private Subject _newSubject = new Domain.Subject();

        public Logics()
        {
            AddSubjectCommand = new RelayCommand(AddSubject);
            ChangeStatusCommand = new RelayCommand(ChangeStatus);
            DeleteSubjectCommand = new RelayCommand(DeleteSubject);
            SaveCommand = new RelayCommand(Save);
            FilterCommand = new RelayCommand(Filter);
            NewSubject = new Domain.Subject();
            Subjects = new ObservableCollection<Subject>();
            AllSubjects = new ObservableCollection<Subject>();

            String path = Path.Combine(Directory.GetCurrentDirectory(), "save.txt");

            if (File.Exists(path))
            {
                string[] save = File.ReadAllText(path).Split('\n');

                
                foreach (string subject in save)
                {
                    if (!subject.Any(x => char.IsLetter(x))) continue;
                    Subject subj = new Subject(subject.Split(',')[0], Boolean.Parse(subject.Split(',')[1]));
                    Subjects.Add(subj);
                    AllSubjects.Add(subj);
                }
            }
        }
        public ObservableCollection<Subject> AllSubjects { get; set; } 
        public ObservableCollection<Domain.Subject> Subjects { get; set; }
        public RelayCommand AddSubjectCommand { get; set; }
        public RelayCommand DeleteSubjectCommand { get; set; }
        public RelayCommand ChangeStatusCommand { get; set; }
        public RelayCommand RadioButtonCheckedCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand FilterCommand { get; set; }
        public Domain.Subject SelectedSubject { get; set; }
        public List<bool> Statuses { get; set; } = new List<bool>() { true, false };
        public bool AllFilter { get; set; } = true;
        public bool PassedFilter { get; set; }
        public bool NotPassedFilter { get; set; }
        public Domain.Subject NewSubject {
            get { return _newSubject; }
            set
            {
                _newSubject = value;
                NotifyPropertyChanged("NewSubject");
            }
        }

        public string SelectedFilter { get; set; }

        private void AddSubject()
        {
            bool canBeAdded = NewSubject.Name != null && 
                              NewSubject.Name != "" && 
                              !Subjects.Select(p => p.Name).Contains(NewSubject.Name);

            if (canBeAdded)
            {
                Subject subject = new Domain.Subject(NewSubject.Name, NewSubject.Status);
                Subjects = new ObservableCollection<Subject>();
                AllSubjects.Add(subject);
                foreach (Subject subj in AllSubjects)
                    Subjects.Add(subj); 
                NewSubject = new Domain.Subject();
            }
        }
        private void DeleteSubject()
        {
            Subjects.Remove(SelectedSubject);
            AllSubjects.Remove(SelectedSubject);
            SelectedSubject = null;
        }

        private void ChangeStatus()
        {
            if (SelectedSubject != null)
                SelectedSubject.Status = !SelectedSubject.Status;
        }

        private void Save()
        {
            String path = Path.Combine(Directory.GetCurrentDirectory(), "save.txt");
            List<string> save = new List<string>();
            foreach (Subject subject in Subjects)
            {
                save.Add(subject.Name + ',' + subject.Status.ToString());
            }
            File.WriteAllLines(path, save);
        }

        private void Filter()
        {
            if (AllFilter)
            {
                Subjects = AllSubjects;
                NotifyPropertyChanged("Subjects");
            }
            else if (PassedFilter)
            {
                Subjects = new ObservableCollection<Subject>();
                foreach (Subject subj in AllSubjects.Where(x => x.Status))
                    Subjects.Add(subj);
                NotifyPropertyChanged("Subjects");
            } 
            else if (NotPassedFilter)
            {
                Subjects = new ObservableCollection<Subject>();
                foreach (Subject subj in AllSubjects.Where(x => !x.Status))
                    Subjects.Add(subj);
                NotifyPropertyChanged("Subjects");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public virtual void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
