using projekt.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Shared.Interfaces
{
    public interface ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis(string text);
    }
}
