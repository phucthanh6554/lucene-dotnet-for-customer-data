using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer.Api.Entities
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("RegoNumber", TypeName = "nvarchar(20)")]
        public string RegoNumber { get; set; }

        [Column("VIN", TypeName = "nvarchar(20)")]
        public string VIN { get; set; }

        [Column("VehicleMake", TypeName = "nvarchar(20)")]
        public string VehicleMake { get; set; }

        [Column("VehicleModel", TypeName = "nvarchar(20)")]
        public string VehicleModel { get; set; }

        [Column("CustomerId", TypeName = "int")]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Column("CreatedAt", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt", TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
