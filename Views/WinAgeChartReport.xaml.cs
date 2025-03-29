using System;
using System.Linq;
using System.Windows;
using AcademicPerformance.Classes.DataAdapters;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;

namespace AcademicPerformance.Views
{
    public partial class WinAgeChartReport : Window
    {
        public SeriesCollection AgeSeries { get; set; }
        public List<string> AgeLabels { get; set; }

        public WinAgeChartReport(string className)
        {
            InitializeComponent();
            GenerateAgeChart(className);
            DataContext = this;
        }

        private void GenerateAgeChart(string className)
        {
            var studentAdapter = new StudentAdapter();
            var students = studentAdapter.GetAllUser() // ✅ тут тоже метод GetAllUser, а не GetAllStudents
                .Where(s => !string.IsNullOrEmpty(s.ClassStudent) &&
                            s.ClassStudent.Equals(className, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!students.Any())
            {
                MessageBox.Show("Нет студентов в данном классе.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
                return;
            }

            var ageGroups = students
                .Select(s => DateTime.Now.Year - s.DateOfBirthStudent.Year)
                .GroupBy(age => age)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key.ToString(), g => g.Count());

            AgeLabels = ageGroups.Keys.ToList();
            AgeSeries = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Возраст",
                    Values = new ChartValues<int>(ageGroups.Values)
                }
            };
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}