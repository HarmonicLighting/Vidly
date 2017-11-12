using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(40)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Date of Birth")]
        [Min18YearsIfAMember]
        public Nullable<DateTime> Birthdate { get; set; }

        public Customer(int id, String name, bool isSubscribed, MembershipType membership)
        {
            Id = id;

            Name = name;

            IsSubscribedToNewsLetter = isSubscribed;

            MembershipType = membership;

            MembershipTypeId = membership.Id;
        }

        public Customer() { }
    }
}