using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Nationality", Schema = "dbo")]

    public class Nationality
    {
        public int NationalityId { get; set; }

        [Required(ErrorMessage = "Required field")]
        [StringLength(4, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        public string CountryCode { get; set; }


        [Required(ErrorMessage = "Required field")]
       [StringLength(256, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "The first letter must be uppercase.Only supports letters and vowels")]
        public string NationalityName { get; set; }

        
        public bool State { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}
