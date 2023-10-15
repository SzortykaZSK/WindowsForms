using Projekt1.Shared.Interfaces;
using Projekt1.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Projekt1.Presenters
{
    internal class TextAnalyzerDataPresenter
    {
        private TextBox _tb_Length;
        private TextBox _tb_Letters;
        private TextBox _tb_Digits;
        private TextBox _tb_Special;
        private TextBox _tb_Time;

        private ITextAnalyzerService _textAnalyzerService;
        public TextAnalyzerDataPresenter(TextBox tLength, TextBox tLetters, TextBox tDigit, TextBox tSpecial, TextBox time) { 
            _tb_Digits = tDigit;   
            _tb_Special = tSpecial;
            _tb_Time = time;
            _tb_Length = tLength;
            _tb_Letters = tLetters;

            _textAnalyzerService = new TextAnalyzerService();
        }

        public void PerformTextAnalysis(string text)
        {
            // przeprowadzenie analizy
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var result = _textAnalyzerService.PerformAnalysis(text);
            sw.Stop();

            // drukowanie wyników
            _tb_Length.Text = result.textLength.ToString();
            _tb_Letters.Text = result.hasLetter ? "TAK" : "NIE";
            _tb_Digits.Text = result.hasDigit ? "TAK" : "NIE";
            _tb_Special.Text = result.hasSpecial ? "TAK" : "NIE";
            _tb_Time.Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}
