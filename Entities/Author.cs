using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{ 
    [Table("Author", Schema = "dbo")]
    public class Author
    {
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(128, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\.\s]*$", ErrorMessage = "The first letter must be uppercase.Only supports letters and vowels")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(128, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\.\s]*$", ErrorMessage = "The first letter must be uppercase.Only supports letters and vowels")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Range(1, 13, ErrorMessage = "Value for {0} must be between {1} and {2}.")]

        [ForeignKey(nameof(Nationality))]
        public int NationalityId { get; set; }
        public Nationality Nationality { get; set; }

        public IList<AuthorBook> AuthorBooks { get; set; }
    }
}
