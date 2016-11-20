using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required(ErrorMessage = "Please enter membership type desired.")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}