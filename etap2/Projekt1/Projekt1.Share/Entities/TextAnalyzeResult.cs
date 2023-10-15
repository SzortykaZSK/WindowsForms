using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Shared.Entities
{
    internal class TextAnalyzeResult
    {
        public int textLength;
        public bool hasLetter = false;
        public bool hasDigit = false;
        public bool hasSpecial = false;
    }
}
