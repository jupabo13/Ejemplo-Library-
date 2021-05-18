using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class AuthorBookDTO
    {
        public int AuthorId { get; set; }

        public string FullName { get; set; }

        [Display(Name = "Nationality")]
        public string NationalityNationalityName { get; set; }
    }
}
