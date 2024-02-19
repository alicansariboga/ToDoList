using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Priority
    {
        [Key]
        public int PriorityID { get; set; }
        public string Name { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
