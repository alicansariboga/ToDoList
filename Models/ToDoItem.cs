using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        [Key]
        public int ItemID { get; set; }
        public string Title { get; set; }

        [ForeignKey("PriorityID")]
        public int PriorityID { get; set; } //FK
        public Priority Priority { get; set; }
        public bool IsDone { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; } // Nullable
        public DateTime? DeleteDate { get; set; } // Nullable
        public DateTime? CompleteDate { get; set; } // Nullable
    }
}
