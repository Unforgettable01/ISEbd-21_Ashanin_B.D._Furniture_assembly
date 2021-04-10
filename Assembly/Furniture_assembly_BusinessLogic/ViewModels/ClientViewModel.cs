﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace Furniture_assembly_BusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("ФИО клиента")]
        public string ClientFIO { get; set; }

        [DataMember]
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DataMember]
        [DisplayName("Почта")]
        public string Email { get; set; }

        [DataMember]
        [DisplayName("Пароль")]
        public string Password { get; set; }
    }

}
