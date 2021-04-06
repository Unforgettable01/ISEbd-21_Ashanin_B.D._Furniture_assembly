using System;
using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    public class ReportFurnitureComponentViewModel
    {
        public string FurnitureName { get; set; }
        public int TotalCount { get; set; }
        public List<Tuple<string, int>> Components { get; set; }
    }

}
