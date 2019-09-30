using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly2.DTOs;
using Vidly2.Models;

namespace Vidly2.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private PlutoContext _context;

        public CustomersController()
        {
            _context = new PlutoContext();
        }

        [HttpGet]
        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDTO>);
        }

        [HttpGet]
        public CustomerDTO GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(a => a.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            return Mapper.Map<Customer,CustomerDTO>(customer);
        }

    }
}
