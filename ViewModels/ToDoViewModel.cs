using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class ToDoViewModel
    {
        public List<ToDoItem> ToDoItems { get; set; }
        public List<Priority> Priorities { get; set; }
    }
}
