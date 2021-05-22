using Furniture_assembly_BusinessLogic.Attributes;
using System.ComponentModel;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    /// <summary>
    /// Исполнитель, выполняющий заказы
    /// </summary>
    public class ImplementerViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }
        [Column(title: "ФИО исполнителя", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DisplayName("ФИО исполнителя")]
        public string ImplementerFIO { get; set; }
        [Column(title: "Время на заказ", width: 100)]
        [DisplayName("Время на заказ")]
        public int WorkingTime { get; set; }
        [Column(title: "Время на перерыв", width: 100)]
        [DisplayName("Время на перерыв")]
        public int PauseTime { get; set; }
    }
}
