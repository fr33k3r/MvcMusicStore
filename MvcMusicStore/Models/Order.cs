using MvcMusicStore.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required]
        [StringLength(160)]
        [Display(Name = "Last Name", Order = 15001)]
        [MaxWords(10, ErrorMessage = "There are too many words in {0}")]
        public string LastName { get; set; }
        [Required]
        [StringLength(160, MinimumLength = 3)]
        [Display(Name = "First Name", Order = 15000)]
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
                ErrorMessage = "Email doesn't look like a valid email address.")]
        public string Email { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]
        public decimal Total { get; set; }
        //public List<OrderDetail> OrderDetails { get; set; }
    }
}