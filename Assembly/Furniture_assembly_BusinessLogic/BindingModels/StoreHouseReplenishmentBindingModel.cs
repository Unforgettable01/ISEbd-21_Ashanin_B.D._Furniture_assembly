﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_assembly_BusinessLogic.BindingModels
{
    public class StoreHouseReplenishmentBindingModel
    {
        public int ComponentId { get; set; }
        public int StoreHouseId { get; set; }
        public int Count { get; set; }
    }
}
