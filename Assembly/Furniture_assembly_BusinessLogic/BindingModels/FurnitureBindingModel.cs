using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.BindingModels
{
    /// <summary>
    /// Мебель, изготавливаемая на производстве
    /// </summary>
    public class FurnitureBindingModel
    {
        public int? Id { get; set; }
        public string FurnitureName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> FurnitureComponents { get; set; }
    }
}
