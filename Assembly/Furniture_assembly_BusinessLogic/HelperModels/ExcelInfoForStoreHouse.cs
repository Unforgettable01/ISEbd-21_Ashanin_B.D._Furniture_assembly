using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    public class ExcelInfoForStoreHouse
    {
        public string FileName { get; set; }

        public string Title { get; set; }

        public List<ReportStoreHouseComponentsViewModel> StoreHouseComponents { get; set; }
    }
}
