using System.ComponentModel.DataAnnotations;

namespace Entities.DTO
{
    public class AuthorsForBookDTO
    {
        public int AuthorId { get; set; }        
        public string FullName { get; set; }        
        public string Nationality { get; set; }

    }
}