using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_ToDoWebApp.ToDoWeb.Models.Entities
{
    public class ToDo
    {
        // [Key] add Pk in her using key attribute or use it in model creation method in dbcontext
        public int Id { get; set; }

        [Display(Name = "ToDo Detail")]
        public string Detail { get; set; } = string.Empty;

        [Display(Name = "Completion Date")]
        [DisplayFormat(DataFormatString = "{0:MMMM/dd/yyyy")]
        public DateTime CompletionDate { get; set; }

        [Display(Name = "Is Completed ?")]
        public bool IsCompleted { get; set; }
    }
}