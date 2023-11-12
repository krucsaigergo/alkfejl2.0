

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PasswordManager.Core.Models
{
    public class Vault
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Website { get; set; } = string.Empty;

        // userId mező hozzáadása a kapcsolathoz
        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigációs tulajdonság a User entitáshoz
        public User? User { get; set; }
    }
}
