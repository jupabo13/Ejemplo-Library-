using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    [Table("AuthorBook", Schema = "dbo")]
    public class AuthorBook
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int PublicationId { get; set; }
        public Book Book { get; set; }
    }
}
