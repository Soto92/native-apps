using System.Windows;

namespace TodoListApp
{
    public partial class MainWindow : Window
    {
        private TaskViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new TaskViewModel();
            DataContext = viewModel;
            taskListBox.ItemsSource = viewModel.Tasks;
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            var taskDescription = taskDescriptionTextBox.Text;
            if (!string.IsNullOrWhiteSpace(taskDescription))
            {
                viewModel.AddTask(taskDescription);
                taskDescriptionTextBox.Clear();
            }
        }
    }
}
