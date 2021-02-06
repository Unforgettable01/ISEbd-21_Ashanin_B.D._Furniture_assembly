using System.ComponentModel;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    /// <summary>
    /// Компонент, требуемый для изготовления мебели
    /// </summary>
    public class ComponentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название компонента")]
        public string ComponentName { get; set; }
    }
}
