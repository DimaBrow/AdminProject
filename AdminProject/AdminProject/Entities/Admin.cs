using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminProject.Entities
{
    public class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public AdminLevel AdminLevel { get; set; }

        [Required]
        public int Age { get; set; }

        //public List<int> ListOfTaskId { get; set; }
        public List<UserTask> ListOfTasks { get; set; }
        
       // public List<int> ListOfUserId { get; set; }
        public List<User> ListOfUsers { get; set; }
    }
    
    public enum AdminLevel
    {
        High,
        Megium,
        Low
    }
}
