using System.Windows;
using AcademicPerformance.ViewModels;

namespace AcademicPerformance.Views
{
    public partial class WinTeacher
    {
        public delegate void Refresh();
        public event Refresh RefreshEvent;

        private VMJournal _viewModel;

        private void RefreshView()
        {
            _viewModel = new VMJournal();
            this.DataContext = null;
            this.DataContext = _viewModel;
        }

        public WinTeacher()
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
                "Вы действительно желаете выйти?", "Информация",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            }
        }

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            WinAdd winAdd = new WinAdd();
            RefreshEvent += new Refresh(RefreshView);
            winAdd.UpdateActor = RefreshEvent;
            winAdd.Show();
        }

        private void miProfile_Click(object sender, RoutedEventArgs e)
        {
            RefreshEvent += new Refresh(RefreshView);
            WinProfileTeacher winProfileTeacher = new WinProfileTeacher { UpdateActor = RefreshEvent };
            winProfileTeacher.Show();
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
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

        private void ReportByClass_Click(object sender, RoutedEventArgs e)
        {
            var classFilter = tbClassFilter.Text.Trim();
            if (string.IsNullOrEmpty(classFilter))
            {
                MessageBox.Show("Введите название класса для отчета.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var reportWindow = new WinClassReport(classFilter);
            reportWindow.Owner = this;
            reportWindow.ShowDialog();
        }

        private void ReportAgeChart_Click(object sender, RoutedEventArgs e)
        {
            var classFilter = tbClassFilter.Text.Trim();
            if (string.IsNullOrEmpty(classFilter))
            {
                MessageBox.Show("Введите название класса для диаграммы.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var chartWindow = new WinAgeChartReport(classFilter);
            chartWindow.Owner = this;
            chartWindow.ShowDialog();
        }
    }
}
