using InventoryManagementSystem.Data;
using InventoryManagementSystem.Model.DomainModel;
using InventoryManagementSystem.Repository.Interfaces;

namespace InventoryManagementSystem.Repository.Service
{
    public class OrdersService: IOrdersService
    {
        private readonly ApplicationDBContext _dbContext;
        public OrdersService(ApplicationDBContext dBContext) {
        _dbContext = dBContext;
        }

        public void AddOrders(Customer orders)
        {
            _dbContext.customers.Add(orders);
            _dbContext.SaveChanges();
        }
    }
}
/*
 * * one to zero or one to one 
 * 
 * 
 * one to many
 * many to many
 */