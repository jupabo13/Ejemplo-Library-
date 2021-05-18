using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Format
    {
        public int FormatId { get; set; }
        [Required(ErrorMessage = "Required field")]
        [StringLength(256, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        public string FormatName { get; set; }
        public bool State { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
