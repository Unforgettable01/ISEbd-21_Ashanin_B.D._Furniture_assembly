using System.Collections.Generic;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    class WordParagraph
    {
        public List<(string, WordParagraphProperties)> Texts { get; set; }

        public WordParagraphProperties TextProperties { get; set; }
    }
}