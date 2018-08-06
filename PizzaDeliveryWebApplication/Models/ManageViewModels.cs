using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace PizzaDeliveryWebApplication.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
      
        public UserModel UserInfo { get; set; }
    }

    /// <summary>
    /// viewmodel for change password view
    /// </summary>
    public class ChangePasswordViewModel
    {
        /// <summary>
        /// old password field
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        /// <summary>
        /// new password field
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// confirm password field
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    /// <summary>
    /// viewmodel for user
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// userid field
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// password field
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// email address field
        /// </summary>
        [Display(Name = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// name field
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// address line1 field
        /// </summary>
        [Display(Name = "Street Address")]
        public string Line1 { get; set; }

        /// <summary>
        /// address line2 field
        /// </summary>
        [Display(Name = "Address Line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// city field
        /// </summary>
        [Display(Name = "City")]
        public string City { get; set; }

        /// <summary>
        /// state field
        /// </summary>
        [Display(Name = "State")]
        public string State { get; set; }

        /// <summary>
        /// country field
        /// </summary>
        [Display(Name = "Country")]
        public string Country { get; set; }

        /// <summary>
        /// zipcode field
        /// </summary>
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// orders list
        /// </summary>
        public List<OrderModel> Orders { get; set; }

        /// <summary>
        /// usermodel constructor
        /// </summary>
        public UserModel()
        {
            UserId = 0;

            Password = string.Empty;
            Name = string.Empty;
            Email = string.Empty;
            Line1 = string.Empty;
            Line2 = string.Empty;
            City = string.Empty;
            Country = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
        }
        public UserModel(int id, string password, string name, string email, string address1,
            string address2, string city, string state, string country, string zipcode)
        {
            UserId = id;
            Password = password;
            Name = name;
            Email = email;
            Line1 = address1;
            Line2 = address2;
            City = city;
            Country = country;
            State = state;
            ZipCode = zipcode;
        }

        public UserModel(string password, string name, string email, string address1,
            string address2, string city, string state, string country, string zipcode)
        {
            Name = name;
            Password = password;
            Email = email;
            Line1 = address1;
            Line2 = address2;
            City = city;
            Country = country;
            State = state;
            ZipCode = zipcode;
        }
    }
}