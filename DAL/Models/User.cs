

using DAL.Models.Base;
using DAL.Models.Enums;
using System.Data;
using System.Text.Json.Serialization;

namespace DAL.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;

        public ICollection<Order> Orders { get; set; }
        public Cart Cart { get; set; }

        [JsonIgnore]//nu o sa ia in calcul si passwordHash
        public string PasswordHash { get; set; } = string.Empty;

        public Role Role { get; set; }
    }
}
