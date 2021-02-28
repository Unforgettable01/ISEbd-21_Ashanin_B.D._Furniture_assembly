﻿using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.BusinessLogics
{
    public class FurnitureLogic
    {
        private readonly IFurnitureStorage _furnitureStorage;
        public FurnitureLogic(IFurnitureStorage secureStorage)
        {
            _furnitureStorage = secureStorage;
        }

        public List<FurnitureViewModel> Read(FurnitureBindingModel model)
        {
            if (model == null)
            {
                return _furnitureStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<FurnitureViewModel> { _furnitureStorage.GetElement(model)};
            }
            return _furnitureStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(FurnitureBindingModel model)
        {
            var element = _furnitureStorage.GetElement(new FurnitureBindingModel
            {
                FurnitureName = model.FurnitureName
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть комплектация с таким названием");
            }
            if (model.Id.HasValue)
            {
                _furnitureStorage.Update(model);
            }
            else
            {
                _furnitureStorage.Insert(model);
            }
        }

        public void Delete(FurnitureBindingModel model)
        {
            var element = _furnitureStorage.GetElement(new FurnitureBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _furnitureStorage.Delete(model);
        }
    }
}
