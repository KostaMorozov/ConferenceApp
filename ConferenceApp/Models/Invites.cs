using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.Models
{
    public class Invites
    {
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you will join")]
        public bool? WillJoin { get; set; }
    }
}
