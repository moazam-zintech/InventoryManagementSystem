using System.ComponentModel.DataAnnotations;
namespace InventoryManagementSystem.Model.DomainModel
{
    public class Orders
    {
        [Key]
        public Guid OrderID { get; set; }
     //   public Customer customer { get; set; }
        public Prodcuts Prodcut { get; set; }
        public DateTime OrderDate { get; set; }
        public float Quanity { get; set; }
        public String Detail { get; set; }
    }
}