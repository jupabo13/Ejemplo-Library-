using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        [Required(ErrorMessage = "Required field")]
        [StringLength(256, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        public string PublisherName { get; set; }
        public bool State { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
