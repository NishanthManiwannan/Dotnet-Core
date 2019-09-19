using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewSalesDetailsVSC.Models;

namespace NewSalesDetailsVSC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {

        private CustomerDetails _customerDetails;

        public CustomerController(CustomerDetails context)
        {
            _customerDetails = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customers>> Get()
        {
            return _customerDetails.Customer_Details.ToList();
        }

        ~CustomerController()
        {
            _customerDetails.Dispose();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}