﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class BookForCreationDTO
    {
        [Required]
        [StringLength(128, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 13)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(512, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        public string SubTitle { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Published { get; set; }

        [Required]
        public int PublisherId { get; set; }
       
        [Required]
        [Range(1, 999, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int NumberOfPages { get; set; }

        [Required]
        [StringLength(1024, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 2)]
        public string Description { get; set; }

        [Url]
        [StringLength(256, ErrorMessage = "Minimum size {3} letters. Maximum {1} letters.", MinimumLength = 11)]
        public string WebSite { get; set; }

        [Required]
        [Range(1, 4, ErrorMessage = "Value for {0} must be between {1} and {2}.")]      
        public int FormatId { get; set; }
    }
}
