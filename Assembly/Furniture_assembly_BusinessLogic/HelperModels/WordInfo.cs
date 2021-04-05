using Furniture_assembly_BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ComponentViewModel> Components { get; set; }
        public List<FurnitureViewModel> Furnitures { get; set; }
    }

}
