using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    public class ReportOrderByDateViewModel
    {
        public DateTime Date { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }
    }
}
