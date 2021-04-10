using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    /// <summary>
    /// Мебель, собираемая на сборке
    /// </summary>
    [DataContract]
    public class FurnitureViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название изделия")]
        public string FurnitureName { get; set; }
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> FurnitureComponents { get; set; }
    }
}
