using Projekt1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projekt1.Shared.Interfaces
{
    public interface ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis(string text);

    }
}
