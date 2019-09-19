using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewSalesDetailsVSC.Models
{
    public class CustomerDetails : DbContext
    {
        public CustomerDetails(DbContextOptions option) : base(option){}

        public DbSet<Customers> Customer_Details { get; set; }
    }
}
