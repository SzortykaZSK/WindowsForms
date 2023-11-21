using projekt.Shared.Entities;
using projekt.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Core.Services
{
    public class TextAnalyzerService : ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis(string text)
        {
            TextAnalyzeResult result = new TextAnalyzeResult();

            char[] specjalne = { '!', '@', '#', '$', '%', '^', '&', '*' };

            int len = text.Length;
            result.lenG = len;
            for (int i = 0; i < len; i++)
            {
                char first = text[i];
                if (Char.IsLetter(first) == true)
                {
                    result.w1 = "Tak";
                    break;
                }
                else
                {
                    result.w1 = "Nie";
                }

            }
            for (int i = 0; i < len; i++)
            {
                char first = text[i];
                for (int j = 0; j < 8; j++)
                {
                    char spec = specjalne[j];
                    if (first == spec)
                    {
                        result.w3 = "Tak";
                        break;
                    }
                    else
                    {
                        result.w3 = "Nie";
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                char first = text[i];
                if (char.IsNumber(first) == true)
                {
                    result.w2 = "Tak";
                    break;
                }
                else
                {
                    result.w2 = "Nie";

                }
            }


            return result;
        }

    }
}
