using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte id { get; set; }
        [Required]
        [StringLength(255)]
        public string membershipName { get; set; }
        public short signupFee { get; set; }
        public byte durationInMonths { get; set; }
        public byte discountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}