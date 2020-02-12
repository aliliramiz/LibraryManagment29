using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagment.Models
{
    // Kitablarin filterlari 
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        public int LangId { get; set; }

        [Required]
        public int AuthorId { get; set; }
      

    }
}