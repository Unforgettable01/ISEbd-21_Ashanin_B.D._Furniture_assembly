using System.Collections.Generic;

namespace Furniture_assembly_List_Implement.Models
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class Furniture
    {
        public int Id { get; set; }
        public string FurnitureName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, int> FurnitureComponents { get; set; }
    }
}
