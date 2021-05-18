using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Magazine", Schema = "dbo")]
    public class Magazine : Publication
    {
        [Required]
        [StringLength(128, ErrorMessage = "Minimum size {3} letters. Maximum 128 letters.", MinimumLength = 13)]
        public string ISSN { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        [StringLength(128, ErrorMessage = "Minimum size {3} letters. Maximum 128 letters.", MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublicationDate { get; set; }
    }
}