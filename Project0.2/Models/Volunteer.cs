using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Project0._2.Models
{
    public class Volunteer
    {
        [HiddenInput]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter volunteer first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter volunteer last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter volunteer username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter volunteer password")]
        [PasswordPropertyText]
        public string Password { get; set; }
        public string CenterPreference { get; set; }
        public string Skills { get; set; }
        public string Availability { get; set; }
        public string Address { get; set; }
        [Phone]
        public string PhoneNum { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Education { get; set; }
        public string Licenses { get; set; }
        public string EmergencyName { get; set; }
        [Phone]
        public string EmergencyPhone { get; set; }
        [EmailAddress]
        public string EmergencyEmail { get; set; }
        public string EmergencyAddress { get; set; }
        public bool DriversLicenseFiled { get; set; }
        public bool SSNFiled { get; set; }
        [Required(ErrorMessage = "Please enter approval status")]
        public string ApprovalStatus { get; set; }
    }
}