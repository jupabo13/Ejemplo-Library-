using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
        [Table("Copy", Schema = "dbo")]
        public class Copy
        {
            public int CopyId { get; set; }
            [Required]
            public int PublicationId { get; set; }
            [ForeignKey("PublicationId")]
            public Publication Publication { get; set; }
            [Required]
            public int ShelfId { get; set; }
            [ForeignKey("ShelfId")]
            public Shelf Shelf { get; set; }
        }    
}
