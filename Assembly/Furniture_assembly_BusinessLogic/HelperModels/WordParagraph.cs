using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    class WordParagraph
    {
        public List<(string, WordTextProperties)> Texts { get; set; }

        public WordTextProperties TextProperties { get; set; }
    }
}