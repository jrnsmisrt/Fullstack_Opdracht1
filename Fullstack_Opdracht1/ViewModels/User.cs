using System.ComponentModel.DataAnnotations;
using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Opdracht1.ViewModels
{
    public class User
    {
        [Required, MinLength(3), MaxLength(50)]
        public string name { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string firstName { get; set; }

        [Required, Range(18, 200)]
        public int age { get; set; }

        [Required, EmailAddress]
        public string email { get; set; }

        [Required]
        [Remote("ValidateCountry", "Validator")]
        public string country { get; set; }

        [Required, Range(1000, 9999)]
        public int zipCode { get; set; }

        [Required]
        [RegularExpression(@"^([\+]?)([0-9]{5,7})([\/])([0-9]{6})$")]
        public string mobilePhoneNumber { get; set; }

    }
}
