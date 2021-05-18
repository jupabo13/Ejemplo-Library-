using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Shelving", Schema = "dbo")]
    public class Shelving
    {
        public int ShelvingId { get; set; }
        [Required]
        public double High { get; set; }
        [Required]
        public double Width { get; set; }
        public ICollection<Shelf> Shelfs { get; set; }
    }
}