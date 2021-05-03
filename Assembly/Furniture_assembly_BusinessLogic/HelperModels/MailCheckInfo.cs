using Furniture_assembly_BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    public class MailCheckInfo
    {
        public string PopHost { get; set; }
        public int PopPort { get; set; }
        public IMessageInfoStorage Storage { get; set; }
        public IClientStorage ClientStorage { get; set; }
    }

}
