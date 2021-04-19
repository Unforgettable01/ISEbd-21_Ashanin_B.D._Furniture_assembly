﻿using Furniture_assembly_BusinessLogic.Enums;
using System;

namespace Furniture_assembly_ListImplement.Models
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FurnitureId { get; set; }
        public int? ImplementerId{ get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }

}
