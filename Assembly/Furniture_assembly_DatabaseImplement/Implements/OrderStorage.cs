using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.Interfaces;
using Furniture_assembly_BusinessLogic.ViewModels;
using Furniture_assembly_DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Furniture_assembly_DatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (var context = new Furniture_assembly_Database())
            {
                     return context.Orders
                    .Include(rec => rec.Furniture)
                    .Include(rec => rec.Client)
                    .Select(CreateModel)
                    .ToList();
            }
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new Furniture_assembly_Database())
            {
                return context.Orders
                     .Where(rec => (!model.DateFrom.HasValue && !model.DateTo.HasValue && rec.DateCreate.Date == model.DateCreate.Date)
                     || (model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate.Date >= model.DateFrom.Value.Date && rec.DateCreate.Date <= model.DateTo.Value.Date)
                     || (model.ClientId.HasValue && rec.ClientId == model.ClientId))
                     .Include(rec => rec.Furniture)
                     .Include(rec => rec.Client)
                     .Select(CreateModel)
                     .ToList();
            }
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }

            using (var context = new Furniture_assembly_Database())
            {
                var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ?
                new OrderViewModel
                {
                    Id = order.Id,
                    FurnitureName = context.Furnitures.FirstOrDefault(r => r.Id == order.FurnitureId).FurnitureName,
                    FurnitureId = order.FurnitureId,
                    Count = order.Count,
                    Sum = order.Sum,
                    Status = order.Status,
                    DateCreate = order.DateCreate,
                    DateImplement = order.DateImplement
                } : null;
            }
        }

        public void Insert(OrderBindingModel model)
        {
            using (var context = new Furniture_assembly_Database())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Orders.Add(CreateModel(model, new Order(), context));
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(OrderBindingModel model)
        {
            using (var context = new Furniture_assembly_Database())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element, context);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new Furniture_assembly_Database())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private Order CreateModel(OrderBindingModel model, Order order, Furniture_assembly_Database context)
        {
            order.FurnitureId = model.FurnitureId;
            order.ClientId = Convert.ToInt32(model.ClientId);
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        private OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                ClientId = order.ClientId,
                FurnitureId = order.FurnitureId,
                ClientFIO = order.Client.ClientFIO,
                FurnitureName = order.Furniture.FurnitureName,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status,
                DateCreate = order.DateCreate,
                DateImplement = order?.DateImplement
            };
        }
    }
}
