using System.ComponentModel.DataAnnotations;
using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace Fullstack_Opdracht1.ViewModels
{
    public class UserVM
    {
        [Required(ErrorMessage = "Name is required"),
            MinLength(3, ErrorMessage = "Name should consist of at least 3 characters"),
            MaxLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "First name is required"),
           MinLength(3, ErrorMessage = "First name should consist of at least 3 characters"),
           MaxLength(50)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Age is required"),
            Range(18, 200, ErrorMessage = "Only 18+ adults allowed")]
        public int Age { get; set; }

        [Required(ErrorMessage = "E-mail address is required"),
            EmailAddress(ErrorMessage = "Not a correct e-mail address format")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [Remote("ValidateCountry", "Register",
            ErrorMessage = "Belgian residents only")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "Zipcode is required"),
            Range(1000, 9999,
            ErrorMessage = "Zipcode should be between 1000 and 9999")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Mobile phonenumber is required")]
        [RegularExpression(@"^((\+)|(00))([0-9]{5})([\/])([0-9]{6})$",
            ErrorMessage = "Mobile phonenumber should be of format +32000/000000 or 0000000/000000")]
        public string? MobilePhoneNumber { get; set; }

    }
}
