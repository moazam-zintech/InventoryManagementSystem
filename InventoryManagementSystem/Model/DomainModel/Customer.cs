using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Model.DomainModel
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public Orders orders { get; set; }
        public string CustomerName { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
