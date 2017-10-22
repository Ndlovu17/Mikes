using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required()]
        [MaxLength(15, ErrorMessage = "Surname required and must not exceed 15 characters")]
        public string Surname { get; set; }


        [Required()]
        [MaxLength(30, ErrorMessage = "First Name required and must not exceed 30 characters")]
        public string FirstName { get; set; }

        [Required()]
        [MaxLength(30, ErrorMessage = "ID Type required and must not exceed 30 characters")]
        public string IDType { get; set; }

        [Required()]
        [MaxLength(13, ErrorMessage = "Invalid ID Entered")]
        public string IdNumber { get; set; }

        [Required()]
        public DateTime DateOfBirth { get; set; }

    }
}