using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.Enums;
using Furniture_assembly_BusinessLogic.HelperModels;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Furniture_assembly_BusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IFurnitureStorage _furnitureStorage;

        private readonly IOrderStorage _orderStorage;

        private readonly IStoreHouseStorage _storeHouseStorage;

        public ReportLogic(IFurnitureStorage furnitureStorage, IOrderStorage orderStorage, IStoreHouseStorage storeHouseStorage)
        {
            _furnitureStorage = furnitureStorage;
            _orderStorage = orderStorage;
            _storeHouseStorage = storeHouseStorage;
        }

        public List<ReportFurnitureComponentViewModel> GetFurnitureComponent()
        {
            var furnitures = _furnitureStorage.GetFullList();

            var list = new List<ReportFurnitureComponentViewModel>();

            foreach (var furniture in furnitures)
            {
                var record = new ReportFurnitureComponentViewModel
                {
                    FurnitureName = furniture.FurnitureName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in furniture.FurnitureComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }

        public List<ReportStoreHouseComponentsViewModel> GetStoreHouseComponent()
        {
            var storeHouses = _storeHouseStorage.GetFullList();

            var list = new List<ReportStoreHouseComponentsViewModel>();

            foreach (var storeHouse in storeHouses)
            {
                var record = new ReportStoreHouseComponentsViewModel
                {
                    StoreHouseName = storeHouse.StoreHouseName,
                    Components = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };
                foreach (var component in storeHouse.StoreHouseComponents)
                {
                    record.Components.Add(new Tuple<string, int>(component.Value.Item1, component.Value.Item2));
                    record.TotalCount += component.Value.Item2;
                }
                list.Add(record);
            }
            return list;
        }

        // Получение списка заказов за определенный период
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return _orderStorage.GetFilteredList(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            }).Select(rec => new ReportOrdersViewModel
            {
                DateCreate = rec.DateCreate,
                FurnitureName = rec.FurnitureName,
                Count = rec.Count,
                Sum = rec.Sum,
                Status = rec.Status
            }).ToList();
        }

        public List<ReportOrderByDateViewModel> GetOrdersInfo()
        {
            return _orderStorage.GetFullList()
                .GroupBy(order => order.DateCreate
                .ToShortDateString())
                .Select(rec => new ReportOrderByDateViewModel
                {
                    Date = Convert.ToDateTime(rec.Key),
                    Count = rec.Count(),
                    Sum = rec.Sum(order => order.Sum)
                })
                .ToList();
        }

        // Сохранение компонент в файл-Word
        public void SaveFurnituresToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                Furnitures = _furnitureStorage.GetFullList()
            });
        }

        public void SaveFurnitureComponentToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список компонентов по изделиям",
                FurnitureComponents = GetFurnitureComponent()
            });
        }

        public void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom.Value,
                DateTo = model.DateTo.Value,
                Orders = GetOrders(model)
            });
        }

        public void SaveStoreHouseComponentsToExcel(ReportBindingModel model)
        {
            SaveToExcel.CreateDocForStoreHouse(new ExcelInfoForStoreHouse
            {
                FileName = model.FileName,
                Title = "Список компонетов по складам",
                StoreHouseComponents = GetStoreHouseComponent()
            });
        }

        public void SaveOrdersInfoToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDocForStoreHouse(new PdfInfoForOrder
            {
                FileName = model.FileName,
                Title = "Список заказов",
                Orders = GetOrdersInfo()
            });
        }

        public void SaveStoreHousesToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDocForStoreHouse(new WordInfoForStoreHouse
            {
                FileName = model.FileName,
                Title = "Список складов",
                StoreHouses = _storeHouseStorage.GetFullList()
            });
        }
    }
}
