using System.Collections.Generic;
using System.Collections.ObjectModel;
using avalonia_ui_2022.Models;

namespace avalonia_ui_2022.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }

        public ObservableCollection<TodoItem> Items { get; }
    }
}