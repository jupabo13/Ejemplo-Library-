using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class BookWithAuthorsDTO
    {
        public int PublicationId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Published { get; set; }

        [Display(Name = "Publisher")]
        public string Publisher { get; set; }

        public int NumberOfPages { get; set; }
        public string Description { get; set; }
        public string WebSite { get; set; }

        [Display(Name = "Format")]
        public string Format { get; set; }

        public List<AuthorsForBookDTO> Author { get; set; }
    }
}
