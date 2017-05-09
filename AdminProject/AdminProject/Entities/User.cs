using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AdminProject.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string FlatNumber { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public int Age { get; set; }

        //public List<int> ListOfTaskId { get; set; }
        public List<UserTask> ListOfTasks { get; set; }
    }
}
