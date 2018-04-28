using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        /// <summary>
        /// Get all customers
        /// </summary>
        [HttpGet]
        public void GetAllCustomers()
        {

        }
        [HttpPost]
        public void AddCustomer()
        {

        }
    }
}