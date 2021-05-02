using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_assembly_BusinessLogic.Interfaces
{
    public interface IStoreHouseStorage
    {
        List<StoreHouseViewModel> GetFullList();

        List<StoreHouseViewModel> GetFilteredList(StoreHouseBindingModel model);

        StoreHouseViewModel GetElement(StoreHouseBindingModel model);

        void Insert(StoreHouseBindingModel model);

        void Update(StoreHouseBindingModel model);

        void Delete(StoreHouseBindingModel model);
    }
}
