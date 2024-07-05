using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TodoListApp
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TaskItem> tasks;
        public ObservableCollection<TaskItem> Tasks 
        {
            get { return tasks; }
            set { tasks = value; OnPropertyChanged(); }
        }

        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskItem>();
        }

        public void AddTask(string description)
        {
            Tasks.Add(new TaskItem { Description = description });
        }

        public void RemoveTask(TaskItem task)
        {
            Tasks.Remove(task);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
