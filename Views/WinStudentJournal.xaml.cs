﻿using System.Windows;
using AcademicPerformance.ViewModels;

namespace AcademicPerformance.Views
{
    /// <summary>
    /// Interaction logic for WinStudent.xaml
    /// </summary>
    public partial class WinStudent
    {
        public delegate void Refresh();
        public event Refresh RefreshEvent;

        private void RefreshView()
        {
            var studentJournal = new VMJournal();
            this.DataContext = null;
            this.DataContext = studentJournal;
        }

        public WinStudent()
        {            
            InitializeComponent();
            RefreshView();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbSearch.Focus();
        }
        
        
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Вы действительно желаете выйти?", 
                "Информация", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            }
        }

        private void MiPersonalProfile_Click(object sender, RoutedEventArgs e)
        {
           
            RefreshEvent += new Refresh(RefreshView);
            WinProfileStudent winProfileStudent = new WinProfileStudent {UpdateActor = RefreshEvent};
            winProfileStudent.Show();
        }

        private void MiExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
    }
}
