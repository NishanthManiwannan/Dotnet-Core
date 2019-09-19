using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewSalesDetailsVSC.Models
{
    public class Customers
    {
        public string Customer_Name { get; set; }

        [Key]
        public int Customer_ID { get; set; }

        public string Address { get; set; }

        public int Mobile { get; set; }

        public int AllowDiscounts { get; set; }

        public int TotalCredits { get; set; }
    }
}
