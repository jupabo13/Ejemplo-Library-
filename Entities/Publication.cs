using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Publication", Schema = "dbo")]
    public class Publication
    {
        public int PublicationId { get; set; }
        public ICollection<Copy> Copies { get; set; }
    }
}