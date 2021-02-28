using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.Interfaces
{
    public interface IFurnitureStorage
    {
        List<FurnitureViewModel> GetFullList();
        List<FurnitureViewModel> GetFilteredList(FurnitureBindingModel model);
        FurnitureViewModel GetElement(FurnitureBindingModel model);
        void Insert(FurnitureBindingModel model);
        void Update(FurnitureBindingModel model);
        void Delete(FurnitureBindingModel model);
    }
}
