using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class BookReturnCreateDTO
    {
        public int PublicationId { get; set; }
        public string ISBN { get; set; }   
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime Published { get; set; }       
        public int PublisherId { get; set; }
        public int NumberOfPages { get; set; }        
        public string Description { get; set; }        
        public string WebSite { get; set; }
        public int FormatId { get; set; }      

    }
}
