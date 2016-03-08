using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Models.User
{
    public class RegisterViewModel
    {

        public RegisterViewModel()
        {
            States = GetStates();
        }

        [Required]
        [Display(Name = "Please Enter Your Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Please Enter Your First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Please Enter Your Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Please Enter Your Address")]
        public string Address { get; set; }

        [Display(Name = "Please Enter Your Apt/Suite")]
        public string AptSuite { get; set; }

        [Required]
        [Display(Name = "Please Enter Your City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Please Select Your State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Please Enter Your Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Please Enter Your Phone Number")]
        public string PhoneNumber { get; set; }

        public IEnumerable<SelectListItem> States { get; set; }




        public IEnumerable<SelectListItem> GetStates()
        {
            var states = new List<SelectListItem>();

            states.Add(new SelectListItem() { Text = "Alabama", Value = "AL" });
            states.Add(new SelectListItem() { Text = "Alaska", Value = "AK" });
            states.Add(new SelectListItem() { Text = "Arizona", Value = "AZ" });
            states.Add(new SelectListItem() { Text = "Arkansas", Value = "AR" });
            states.Add(new SelectListItem() { Text = "California", Value = "CA" });
            states.Add(new SelectListItem() { Text = "Colorado", Value = "CO" });
            states.Add(new SelectListItem() { Text = "Connecticut", Value = "CT" });
            states.Add(new SelectListItem() { Text = "District of Columbia", Value = "DC" });
            states.Add(new SelectListItem() { Text = "Delaware", Value = "DE" });
            states.Add(new SelectListItem() { Text = "Florida", Value = "FL" });
            states.Add(new SelectListItem() { Text = "Georgia", Value = "GA" });
            states.Add(new SelectListItem() { Text = "Hawaii", Value = "HI" });
            states.Add(new SelectListItem() { Text = "Idaho", Value = "ID" });
            states.Add(new SelectListItem() { Text = "Illinois", Value = "IL" });
            states.Add(new SelectListItem() { Text = "Indiana", Value = "IN" });
            states.Add(new SelectListItem() { Text = "Iowa", Value = "IA" });
            states.Add(new SelectListItem() { Text = "Kansas", Value = "KS" });
            states.Add(new SelectListItem() { Text = "Kentucky", Value = "KY" });
            states.Add(new SelectListItem() { Text = "Louisiana", Value = "LA" });
            states.Add(new SelectListItem() { Text = "Maine", Value = "ME" });
            states.Add(new SelectListItem() { Text = "Maryland", Value = "MD" });
            states.Add(new SelectListItem() { Text = "Massachusetts", Value = "MA" });
            states.Add(new SelectListItem() { Text = "Michigan", Value = "MI" });
            states.Add(new SelectListItem() { Text = "Minnesota", Value = "MN" });
            states.Add(new SelectListItem() { Text = "Mississippi", Value = "MS" });
            states.Add(new SelectListItem() { Text = "Missouri", Value = "MO" });
            states.Add(new SelectListItem() { Text = "Montana", Value = "MT" });
            states.Add(new SelectListItem() { Text = "Nebraska", Value = "NE" });
            states.Add(new SelectListItem() { Text = "Nevada", Value = "NV" });
            states.Add(new SelectListItem() { Text = "New Hampshire", Value = "NH" });
            states.Add(new SelectListItem() { Text = "New Jersey", Value = "NJ" });
            states.Add(new SelectListItem() { Text = "New Mexico", Value = "NM" });
            states.Add(new SelectListItem() { Text = "New York", Value = "NY" });
            states.Add(new SelectListItem() { Text = "North Carolina", Value = "NC" });
            states.Add(new SelectListItem() { Text = "North Dakota", Value = "ND" });
            states.Add(new SelectListItem() { Text = "Ohio", Value = "OH" });
            states.Add(new SelectListItem() { Text = "Oklahoma", Value = "OK" });
            states.Add(new SelectListItem() { Text = "Oregon", Value = "OR" });
            states.Add(new SelectListItem() { Text = "Pennsylvania", Value = "PA" });
            states.Add(new SelectListItem() { Text = "Rhode Island", Value = "RI" });
            states.Add(new SelectListItem() { Text = "South Carolina", Value = "SC" });
            states.Add(new SelectListItem() { Text = "South Dakota", Value = "SD" });
            states.Add(new SelectListItem() { Text = "Tennessee", Value = "TN" });
            states.Add(new SelectListItem() { Text = "Texas", Value = "TX" });
            states.Add(new SelectListItem() { Text = "Utah", Value = "UT" });
            states.Add(new SelectListItem() { Text = "Vermont", Value = "VT" });
            states.Add(new SelectListItem() { Text = "Virginia", Value = "VA" });
            states.Add(new SelectListItem() { Text = "Washington", Value = "WA" });
            states.Add(new SelectListItem() { Text = "West Virginia", Value = "WV" });
            states.Add(new SelectListItem() { Text = "Wisconsin", Value = "WI" });
            states.Add(new SelectListItem() { Text = "Wyoming", Value = "WY " }
            );

            return states;
        }

    }
}