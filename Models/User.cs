using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace meet_up_4_git.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string Password { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }
    }
}