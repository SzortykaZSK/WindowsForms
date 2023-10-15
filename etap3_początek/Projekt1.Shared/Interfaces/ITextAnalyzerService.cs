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
        public TextAnalyzeResult PerformAnalysis(string text)
        {
            TextAnalyzeResult textAnalyzeResult = new TextAnalyzeResult();

            string unikalneLitery = new string(text.ToLower().Where(char.IsLetter).Distinct().ToArray());

            string unikalneCyfry = new string(text.Where(char.IsDigit).Distinct().ToArray());

            string unikalneZnakiSpecjalne = new string(text.Where(c => !char.IsLetterOrDigit(c)).Distinct().ToArray());

            if(unikalneLitery != "")
            {
                textAnalyzeResult.hasLetter = true;
            }
            else
            {
                textAnalyzeResult.hasLetter = false;
            }

            if (unikalneCyfry != "")
            {
                textAnalyzeResult.hasDigit = true;
            }
            else
            {
                textAnalyzeResult.hasDigit = false;
            }

            if (unikalneZnakiSpecjalne != "")
            {
                textAnalyzeResult.hasSpecial = true;
            }
            else
            {
                textAnalyzeResult.hasSpecial = false;
            }

            textAnalyzeResult.textLength = text.Length;

            return textAnalyzeResult;
        }
    }
}
