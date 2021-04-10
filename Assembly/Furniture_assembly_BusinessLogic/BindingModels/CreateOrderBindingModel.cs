using System.Runtime.Serialization;

namespace Furniture_assembly_BusinessLogic.BindingModels
{
        /// <summary>
        /// Данные от клиента, для создания заказа
        /// </summary>
        [DataContract]
        public class CreateOrderBindingModel
        {
            [DataMember]
            public int ClientId { get; set; }
            [DataMember]
            public int FurnitureId { get; set; }
            [DataMember]
            public int Count { get; set; }
            [DataMember]
            public decimal Sum { get; set; }
        }
}
