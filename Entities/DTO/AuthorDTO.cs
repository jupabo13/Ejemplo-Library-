using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    //Salida: Desde la DB hacia el Cliente. es Seguro y es Idenpotente.
    public class AuthorDTO
    {
        public int AuthorId { get; set; }     
        
        public string  FullName { get; set; }

        [Display(Name ="Nationality")]
        public string Nationality { get; set; }
        
        public List<BookDTO> Book { get; set; }

    }
}
