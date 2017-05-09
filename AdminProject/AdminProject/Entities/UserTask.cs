using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminProject.Entities
{
    public class UserTask
    {
       [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
       public int Id { get; set; }

       [Required, MaxLength(100)]
       public string Title { get; set; }

       [Required]
       public Category Category { get; set; }

       [Required]
       public string Description { get; set; }

       [Required]
       public UserTaskStatus Status { get; set; }
    }


    public enum Category
    {
        General,
        Software,
        Hardware,
        Network
    }
    public enum UserTaskStatus
    {
        AssignedToAdmin,
        InProgress,
        Ended
    }
}
