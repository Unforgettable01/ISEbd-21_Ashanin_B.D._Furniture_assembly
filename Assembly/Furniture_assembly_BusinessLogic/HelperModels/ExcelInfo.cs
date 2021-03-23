using Furniture_assembly_BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportFurnitureComponentViewModel> FurnitureComponents { get; set; }
    }
}
