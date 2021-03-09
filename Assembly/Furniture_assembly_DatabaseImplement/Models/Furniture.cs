using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_assembly_DatabaseImplement.Models
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class Furniture
    {
        public int Id { get; set; }
        [Required]
        public string FurnitureName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("FurnitureId")]
        public virtual List<FurnitureComponent> FurnitureComponents { get; set; }
        [ForeignKey("FurnitureId")]
        public virtual List<Order> Order { get; set; }
    }
}
