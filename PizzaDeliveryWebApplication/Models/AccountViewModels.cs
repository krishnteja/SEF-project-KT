using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaDeliveryWebApplication.Models
{
    /// <summary>
    /// View Model for Login
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Email address field
        /// </summary>
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Password field
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Remember me field
        /// </summary>
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    /// <summary>
    /// View Model for Register View
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// Email address field
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Password field
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// confirm password field
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// name field
        /// </summary>
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        /// <summary>
        /// Line 1 address field
        /// </summary>
        [Required]
        [Display(Name ="Street Address")]
        public string Line1 { get; set; }

        /// <summary>
        /// line 2 address field
        /// </summary>
        [Display(Name ="Address Line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// city field
        /// </summary>
        [Required]
        [Display(Name ="City")]
        public string City { get; set; }

        /// <summary>
        /// State field
        /// </summary>
        [Required]
        [Display(Name ="State")]
        public string State { get; set; }

        /// <summary>
        /// Country field
        /// </summary>
        [Required]
        [Display(Name ="Country")]
        public string Country { get; set; }

        /// <summary>
        /// Zip code field
        /// </summary>
        [Required]
        [Display(Name ="Zip code")]
        public string ZipCode { get; set; }
    }
}
