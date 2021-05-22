using Furniture_assembly_BusinessLogic.Attributes;
using System.ComponentModel;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления мебели
    /// </summary>
    public class ComponentViewModel
    {
        [Column(title: "Номер", width: 100)]
        public int Id { get; set; }
        [Column(title: "Название компонента", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DisplayName("Название компонента")]
        public string ComponentName { get; set; }
    }
}
