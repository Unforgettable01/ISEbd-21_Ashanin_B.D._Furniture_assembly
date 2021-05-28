

using System.ComponentModel.DataAnnotations;

namespace Furniture_assembly_DatabaseImplement.Models
{
    /// <summary>
    /// Сколько компонентов, требуется при изготовлении изделия
    /// </summary>
    public class FurnitureComponent
    {
        public int Id { get; set; }
        public int FurnitureId { get; set; }
        public int ComponentId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Component Component { get; set; }
        public virtual Furniture Furniture { get; set; }
    }
}
