using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Model.DomainModel
{
    public class inventory
    {
        [Key]
        public Guid Id { get; set; }
        public Prodcuts Prodcut { get; set; }
        public DateOnly DemandDate { get; set; }
        public DateOnly RecievedDate { get; set; }
        public string  Stock { get; set; }
    }
}
