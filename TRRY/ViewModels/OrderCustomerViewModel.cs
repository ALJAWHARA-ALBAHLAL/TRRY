using System.Collections.Generic;
using TRRY.Models;

namespace TRRY.ViewModels
{
    public class OrderCustomerViewModel
    {
        public int OrderId { get; set; }
        public string status { get; set; }


        public int CustomerId { get; set; }
        public List<Customer> Customers{ get; set; }

    }
}
