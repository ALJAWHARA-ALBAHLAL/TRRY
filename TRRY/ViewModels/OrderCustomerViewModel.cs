using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TRRY.Models;

namespace TRRY.ViewModels
{
    public class OrderCustomerViewModel
    {
        //Order
        public int OrderId { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        public string status { get; set; }

        //Customer
        public int CustomerId { get; set; }
        public List<Customer> Customers{ get; set; }

    }
}
