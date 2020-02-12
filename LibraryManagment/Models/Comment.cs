using LibraryManagment.Forms;
using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagment.Models
{

    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public User User { get; set; }
        //public Customer Person { get; set; }
    }
}
