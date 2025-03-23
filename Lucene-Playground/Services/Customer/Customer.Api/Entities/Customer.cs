using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Api.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("FirstName", TypeName = "nvarchar(255)")]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "nvarchar(255)")]
        public string LastName { get; set; }

        [Column("Birthdate", TypeName = "datetime")]
        public DateTime Birthdate { get; set; }

        [Column("Address", TypeName = "nvarchar(255)")]
        public string Address { get; set; }

        [Column("Email", TypeName = "nvarchar(255)")]
        public string Email { get; set; }

        [Column("PhoneAreaCode", TypeName = "varchar(5)")]
        public string PhoneAreaCode { get; set; }

        [Column("PhoneNumber", TypeName = "varchar(20)")]
        public string PhoneNumber { get; set; }

        [Column("CreatedAt", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt", TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }

        public virtual IEnumerable<Vehicle> Vehicles { get; set; } = Enumerable.Empty<Vehicle>();
    }
}
