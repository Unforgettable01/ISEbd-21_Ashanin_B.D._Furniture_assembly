using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.Enums;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_BusinessLogic.ViewModels;
using Furniture_assembly_ListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Furniture_assembly_ListImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly DataListSingleton source;

        public OrderStorage()
        {
            source = DataListSingleton.GetInstance();
        }

        public List<OrderViewModel> GetFullList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                result.Add(CreateModel(order));
            }
            return result;
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var order in source.Orders)
            {
                if ((!model.DateFrom.HasValue && !model.DateTo.HasValue && order.DateCreate.Date == model.DateCreate.Date)
                     || (model.DateFrom.HasValue && model.DateTo.HasValue && order.DateCreate.Date >= model.DateFrom.Value.Date && order.DateCreate.Date <= model.DateTo.Value.Date)
                     || (model.ClientId.HasValue && order.ClientId == model.ClientId)
                     || (model.FreeOrders.HasValue && model.FreeOrders.Value && order.Status == OrderStatus.Принят)
                     || (model.ImplementerId.HasValue && order.ImplementerId == model.ImplementerId && order.Status == OrderStatus.Выполняется))
                {
                    result.Add(CreateModel(order));
                }
            }
            return result;
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var order in source.Orders)
            {
                if (order.Id == model.Id)
                {
                    return CreateModel(order);
                }
            }
            return null;
        }

        public void Insert(OrderBindingModel model)
        {
            Order tempOrder = new Order { Id = 1 };
            foreach (var order in source.Orders)
            {
                if (order.Id >= tempOrder.Id)
                {
                    tempOrder.Id = order.Id + 1;
                }
            }
            source.Orders.Add(CreateModel(model, tempOrder));
        }

        public void Update(OrderBindingModel model)
        {
            Order tempOrder = null;
            foreach (var order in source.Orders)
            {
                if (order.Id == model.Id)
                {
                    tempOrder = order;
                }
            }
            if (tempOrder == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempOrder);
        }

        public void Delete(OrderBindingModel model)
        {
            for (int i = 0; i < source.Orders.Count; ++i)
            {
                if (source.Orders[i].Id == model.Id.Value)
                {
                    source.Orders.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.FurnitureId = model.FurnitureId;
            order.ClientId = model.ClientId.Value;
            order.ImplementerId = model.ImplementerId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }

        //private OrderViewModel CreateModel(Order order)
        //{
        //    OrderViewModel tempOrder = new OrderViewModel
        //    {
        //        Id = order.Id,
        //        FurnitureId = order.FurnitureId,
        //        ClientId = order.ClientId,
        //        ImplementerId = order.ImplementerId,
        //        ImplementerFIO = string.Empty,
        //        ClientFIO = string.Empty,
        //        FurnitureName = source.Furnitures.FirstOrDefault(furniture => furniture.Id == order.FurnitureId).FurnitureName,
        //        Count = order.Count,
        //        Sum = order.Sum,
        //        Status = order.Status,
        //        DateCreate = order.DateCreate,
        //        DateImplement = order.DateImplement
        //    };
        //    foreach (var furniture in source.Furnitures)
        //    {
        //        if (furniture.Id == order.FurnitureId)
        //        {
        //            tempOrder.FurnitureName = furniture.FurnitureName;
        //            break;
        //        }
        //    }

        //    foreach (var client in source.Clients)
        //    {
        //        if (client.Id == order.ClientId)
        //        {
        //            tempOrder.ClientFIO = client.ClientFIO;
        //            break;
        //        }
        //    }

        //    if (tempOrder.ImplementerId != null)
        //    {
        //        foreach (var implementer in source.Implementers)
        //        {
        //            if (implementer.Id == order.ImplementerId)
        //            {
        //                tempOrder.ImplementerFIO = implementer.ImplementerFIO;
        //                break;
        //            }
        //        }
        //    }
        //    return tempOrder;
        //}
        private OrderViewModel CreateModel(Order order)
        {
            string furnitureName = null;
            foreach (var furniture in source.Furnitures)
            {
                if (furniture.Id == order.FurnitureId)
                {
                    furnitureName = furniture.FurnitureName;
                }
            }
            string clientFIO = null;
            foreach (var client in source.Clients)
            {
                if (client.Id == order.ClientId)
                {
                    clientFIO = client.ClientFIO;
                }
            }

            string ImplementerFIO = null;
            foreach (var implementer in source.Implementers)
            {
                if (implementer.Id == order.FurnitureId)
                {
                    ImplementerFIO = implementer.ImplementerFIO;
                }
            }
            return new OrderViewModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                FurnitureId = order.FurnitureId,
                ImplementerId = order.ImplementerId,
                ImplementerFIO = ImplementerFIO,
                ClientFIO = clientFIO,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status,
                FurnitureName = furnitureName,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}
