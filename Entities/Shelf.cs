using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Shelf", Schema = "dbo")]
    public class Shelf
    {
        public int ShelfId { get; set; }
        [Required]
        public int ShelvingId { get; set; }
        [ForeignKey("ShelvingId")]
        public Shelving Shelving { get; set; }
        public ICollection<Copy> Copies { get; set; }
    }
}