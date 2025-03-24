using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lucene.Api.Entities
{
    public class SyncDataControl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("IndexName", TypeName = "nvarchar(255)")]
        public string IndexName { get; set; }

        [Column("IndexPath", TypeName = "nvarchar(500)")]
        public string Path { get; set; }

        [Column("CreatedAt", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }

        [Column("LastSync", TypeName = "datetime")]
        public DateTime LastSync { get; set; }
    }
}
