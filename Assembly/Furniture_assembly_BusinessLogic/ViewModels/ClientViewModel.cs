using Furniture_assembly_BusinessLogic.Attributes;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [Column(title: "Номер", width: 100)]
        [DataMember]
        public int Id { get; set; }
        [Column(title: "ФИО клиента", width: 150)]
        [DataMember]
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }
        [Column(title: "Логин", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("Почта")]
        public string Email { get; set; }
        [Column(title: "Пароль", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }

}
