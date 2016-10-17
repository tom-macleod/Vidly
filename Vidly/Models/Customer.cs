using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Min18YearsIfAMember]
        [Display(Name = "Date of Birth")]
        public DateTime? birthdate { get; set; }

        public bool isSubscribedToNewsLetter { get; set; }

        public MembershipType membershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte membershipTypeId { get; set; }

    }
}