﻿using System.ComponentModel;

namespace AcademicPerformance.Classes.DataModels
{
    public class JournalModel : INotifyPropertyChanged
    {
       
        private int idStudent;
        public int IdStudent
        {
            get { return idStudent; }
            set { idStudent = value; OnPropertyChanged(nameof(IdStudent)); }
        }


        private int idTeacher;
        public int IdTeacher
        {
            get { return idTeacher; }
            set { idTeacher = value; OnPropertyChanged(nameof(IdTeacher)); }
        }


        private int idDiscipline;
        public int IdDiscipline
        {
            get { return idDiscipline; }
            set { idDiscipline = value; OnPropertyChanged(nameof(IdDiscipline)); }
        }


        private int idEvaluation;
        public int IdEvaluation
        {
            get { return idEvaluation; }
            set { idEvaluation = value; OnPropertyChanged(nameof(IdEvaluation)); }
        }

        private int idJournal;
        public int IdJournal
        {
            get { return idJournal; }
            set { idJournal = value; OnPropertyChanged(nameof(IdJournal)); }
        }


        //Поля отсутствуют внутри таблицы БД и существуют только в модели
        private string lastNameStudent;
        public string LastNameStudent
        {
            get { return lastNameStudent; }
            set { lastNameStudent = value; OnPropertyChanged(nameof(LastNameStudent)); }
        }
        private string firstNameStudent;
        public string FirstNameStudent
        {
            get { return firstNameStudent; }
            set { firstNameStudent = value; OnPropertyChanged(nameof(FirstNameStudent)); }
        }
        private string middleNameStudent;
        public string MiddleNameStudent
        {
            get { return middleNameStudent; }
            set { middleNameStudent = value; OnPropertyChanged(nameof(MiddleNameStudent)); }
        }

        private string lastNameTeacher;
        public string LastNameTeacher
        {
            get { return lastNameTeacher; }
            set { lastNameTeacher = value; OnPropertyChanged(nameof(LastNameTeacher)); }
        }
        private string firstNameTeacher;
        public string FirstNameTeacher
        {
            get { return firstNameTeacher; }
            set { firstNameTeacher = value; OnPropertyChanged(nameof(FirstNameTeacher)); }
        }
        private string middleNameTeacher;
        public string MiddleNameTeacher
        {
            get { return middleNameTeacher; }
            set { middleNameTeacher = value; OnPropertyChanged(nameof(MiddleNameTeacher)); }
        }
        



        private string fIOStudent;
        public string FIOStudent
        {
            get
            {
                fIOStudent = LastNameStudent;
                fIOStudent += " " + FirstNameStudent;
                if (MiddleNameStudent != default) fIOStudent += " " + MiddleNameStudent;
                return fIOStudent;
            }
            set { fIOStudent = value; OnPropertyChanged(nameof(FIOStudent)); }
        }


        private int numberEvaluation;
        public int NumberEvaluation
        {
            get { return numberEvaluation; }
            set { numberEvaluation = value; OnPropertyChanged(nameof(NumberEvaluation)); }
        }


        private string nameEvaluation;
        public string NameEvaluation
        {
            get { return nameEvaluation; }
            set { nameEvaluation = value; OnPropertyChanged(nameof(NameEvaluation)); }
        }


        private string fIOTeacher;
        public string FIOTeacher
        {
            get
            {
                fIOTeacher = LastNameTeacher;
                fIOTeacher += " " + FirstNameTeacher;
                if (MiddleNameTeacher != default) fIOStudent += " " + MiddleNameTeacher;
                return fIOTeacher;

            }
            set { fIOTeacher = value; OnPropertyChanged(nameof(FIOTeacher)); }
        }


        private string nameDiscipline;
        public string NameDiscipline
        {
            get { return nameDiscipline; }
            set { nameDiscipline = value; OnPropertyChanged(nameof(NameDiscipline)); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));

        }

    }
}
