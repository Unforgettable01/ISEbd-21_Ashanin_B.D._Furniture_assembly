using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.BusinessLogics
{
    public class FurnitureLogic
    {
        private readonly IProductStorage _productStorage;
        public FurnitureLogic(IProductStorage secureStorage)
        {
            _productStorage = secureStorage;
        }

        public List<ProductViewModel> Read(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return _productStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ProductViewModel> { _productStorage.GetElement(model)
};
            }
            return _productStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(FurnitureBindingModel model)
        {
            var element = _productStorage.GetElement(new FurnitureBindingModel
            {
                ProductName = model.ProductName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть комплектация с таким названием");
            }
            if (model.Id.HasValue)
            {
                _productStorage.Update(model);
            }
            else
            {
                _productStorage.Insert(model);
            }
        }

        public void Delete(FurnitureBindingModel model)
        {
            var element = _productStorage.GetElement(new FurnitureBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _productStorage.Delete(model);
        }
    }
}
