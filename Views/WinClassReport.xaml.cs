using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using AcademicPerformance.Classes.DataAdapters;

namespace AcademicPerformance.Views
{
    public partial class WinClassReport : Window
    {
        public WinClassReport(string className)
        {
            InitializeComponent();
            GenerateReport(className);
        }

        private void GenerateReport(string className)
        {
            var journalAdapter = new JournalAdapter();
            var journalList = journalAdapter.GetAllJournalFull();

            var classStudents = journalList
                .Where(j => j.ClassStudent != null && j.ClassStudent.ToLower() == className.ToLower())
                .GroupBy(j => j.FIOStudent)
                .Select(g => new
                {
                    FIOStudent = g.Key,
                    Records = g.Select(j => new
                    {
                        Discipline = j.NameDiscipline,
                        Evaluation = j.NumberEvaluation,
                        EvaluationName = j.NameEvaluation
                    }).ToList()
                }).ToList();

            if (!classStudents.Any())
            {
                MessageBox.Show("Нет данных для указанного класса.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
                return;
            }

            foreach (var student in classStudents)
            {
                var studentBlock = new TextBlock
                {
                    Text = student.FIOStudent,
                    FontSize = 16,
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(0, 10, 0, 5)
                };
                ReportContentPanel.Children.Add(studentBlock);

                foreach (var record in student.Records)
                {
                    var recordBlock = new TextBlock
                    {
                        Text = $"{record.Discipline}: {record.Evaluation} ({record.EvaluationName})",
                        Margin = new Thickness(20, 0, 0, 2)
                    };
                    ReportContentPanel.Children.Add(recordBlock);
                }

                var separator = new Separator
                {
                    Margin = new Thickness(0, 10, 0, 10),
                    Background = Brushes.Gray,
                    Height = 1
                };
                ReportContentPanel.Children.Add(separator);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
