using Projekt1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Shared.Interfaces
{
    internal interface ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis()
        {
            TextAnalyzeResult TAR = new TextAnalyzeResult();
            
            return TAR;
        }
    }
}
