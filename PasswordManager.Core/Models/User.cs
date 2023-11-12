

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PasswordManager.Core.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public int Id { get; set; } // Id mező hozzáadva

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        // Navigációs tulajdonság a Vault entitáshoz
        public ICollection<Vault>? Vaults { get; set; }

    }
}
