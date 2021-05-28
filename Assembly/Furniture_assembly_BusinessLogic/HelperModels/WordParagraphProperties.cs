﻿using DocumentFormat.OpenXml.Wordprocessing;

namespace Furniture_assembly_BusinessLogic.HelperModels
{
    public class WordParagraphProperties
    {
        public string Size { get; set; }

        public bool Bold { get; set; }

        public JustificationValues JustificationValues { get; set; }
    }

}
