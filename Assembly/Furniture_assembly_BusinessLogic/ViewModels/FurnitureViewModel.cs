using Furniture_assembly_BusinessLogic.Attributes;
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
        [Column(title: "Номер", width: 100)]
        [DataMember]
        public int Id { get; set; }
        [Column(title: "Название изделия", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("Название изделия")]
        public string FurnitureName { get; set; }
        [Column(title: "Цена", width: 100)]
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [Column(visible: false)]
        [DataMember]
        public Dictionary<int, (string, int)> FurnitureComponents { get; set; }
    }
}
