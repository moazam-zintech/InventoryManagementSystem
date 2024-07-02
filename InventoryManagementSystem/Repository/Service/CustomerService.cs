using InventoryManagementSystem.Data;
using InventoryManagementSystem.Model.DomainModel;
using InventoryManagementSystem.Repository.Interfaces;

namespace InventoryManagementSystem.Repository.Service
{
    public class CustomerService: ICustomerService
    {
        private readonly ApplicationDBContext _context;
        public CustomerService(ApplicationDBContext context) {
        _context = context;
        }
        public void AddCustomer(Customer customer)
        {

           _context.customers.Add(customer);
            _context.SaveChanges();
        }
    }
}
