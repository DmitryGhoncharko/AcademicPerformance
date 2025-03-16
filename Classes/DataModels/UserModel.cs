﻿using System.ComponentModel;

namespace AcademicPerformance.Classes.DataModels
{
    public class UserModel:INotifyPropertyChanged
    {
        
        private int idUser;
        public int IdUser
        {
            get { return idUser;}
            set { idUser = value; OnPropertyChanged(nameof(IdUser)); }
        }
        private string loginUser;
        public string LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; OnPropertyChanged(nameof(LoginUser)); }
        }
        private int roleUser;
        public int RoleUser
        {
            get { return roleUser; }
            set { roleUser = value; OnPropertyChanged(nameof(RoleUser)); }
        }
        private string passwordUser;
        public string PasswordUser
        {
            get { return passwordUser; }
            set { passwordUser = value; OnPropertyChanged(nameof(PasswordUser)); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));

        }
    }
}
