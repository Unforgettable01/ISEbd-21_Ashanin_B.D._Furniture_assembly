namespace Furniture_assembly_BusinessLogic.BindingModels
{
    /// <summary>
    /// Данные от клиента, для создания заказа
    /// </summary>

    public class CreateOrderBindingModel
    {
        public int FurnitureId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
