using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using LibraryManagment.Models;
using LibraryManagment.Data;

namespace LibraryManagment.Forms
{
    public enum UserLevel
    {
        Admin,
        Moderator
    }

    public class User
    {

        // Adminin malumatlari
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public UserLevel Level { get; set; }

        public List<Comment> Comments { get; set; }
        public List<Order> Orders { get; set; }
    }
}