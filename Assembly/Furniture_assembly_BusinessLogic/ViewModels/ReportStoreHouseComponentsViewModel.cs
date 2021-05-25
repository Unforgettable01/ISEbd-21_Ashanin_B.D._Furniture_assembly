using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    public class ReportStoreHouseComponentsViewModel
    {
        public string StoreHouseName { get; set; }

        public int TotalCount { get; set; }

        public List<Tuple<string, int>> Components { get; set; }
    }
}
