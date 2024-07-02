using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Model.DomainModel
{
    public class Prodcuts
    {
        [Key]
        public Guid ProdcutId { get; set; }
        public string ProductName { get; set; }

        public float Price { get; set; }
    }
}
