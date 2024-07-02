using InventoryManagementSystem.Model.DomainModel;
using InventoryManagementSystem.Model.DTO;
using InventoryManagementSystem.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;

namespace InventoryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _orders;
        public OrdersController(IOrdersService orders) {
        _orders = orders;
        }

        [HttpPost]
        public void AddOrders(OrdersDTO ordersDTO)
        {

            var res=new Customer {  orders 
                = new Orders
            {
                Prodcut= new Prodcuts
                {
                    ProductName = ordersDTO.ProductName,

                },
                Detail =ordersDTO.Details,
                OrderDate=DateTime.Now,
                Quanity = ordersDTO.Quanity,
            }
            };

            _orders.AddOrders(res);
        }
    }
}
