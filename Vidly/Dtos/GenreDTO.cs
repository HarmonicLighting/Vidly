using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class GenreDTO
    {
        public byte Id { get; set; }
        [Required]
        public String Name { get; set; }
    }
}