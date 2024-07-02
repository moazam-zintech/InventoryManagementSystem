
using InventoryManagementSystem.Model.DomainModel;
using InventoryManagementSystem.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customer)
        {
            _customerService = customer;
        }

        [HttpPost]

        public void AddCusomer(CustomerDTO customer)
        {
            var res = new Customer
            {
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                Phone = customer.Phone,
                Department = customer.Department
            };
            _customerService.AddCustomer(res);
        }

    }
}
