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
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
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