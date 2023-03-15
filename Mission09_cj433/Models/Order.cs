using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cj433.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address")]
        public string AddressLine1 { get; set; }

        [Required(ErrorMessage = "Please enter city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state name")]
        public string State { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter country name")]
        public string Country { get; set; }
    }
}