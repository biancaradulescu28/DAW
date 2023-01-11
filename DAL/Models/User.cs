

using DAL.Models.Base;
using System.Data;
using System.Text.Json.Serialization;

namespace DAL.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Cart Cart { get; set; }

        //[JsonIgnore]//nu o sa ia in calcul si passwordHash
        //public string PasswordHash { get; set; }

        //public Role Role { get; set; }
    }
}
