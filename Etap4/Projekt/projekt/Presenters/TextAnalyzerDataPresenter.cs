using projekt.Core.Services;
using projekt.Shared.Entities;
using projekt.Shared.Interfaces;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace projekt.Presenters
{
    public class TextAnalyzerDataPresenter
    {

        private TextBox _tb_AllSymbols;
        private TextBox _tb_UniqueItems;
        private TextBox _tb_Entropy;
        private TextBox _tb_Time;
        private DataGridView _dataGridView;

        private ITextStatisticsService _myTextService;


        public TextAnalyzerDataPresenter(TextBox tb_AllSymbols, TextBox tb_UniqueItems, TextBox tb_Entropy,
            TextBox tb_Time, DataGridView dataGridView)
        {

            _tb_AllSymbols = tb_AllSymbols;
            _tb_UniqueItems = tb_UniqueItems;
            _tb_Entropy = tb_Entropy;
            _tb_Time = tb_Time;
            _dataGridView = dataGridView;


            _myTextService = new TextStatisticsSevice();
        }


        public void PerformTextAnalysis(string text)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            TextStatisticsData textStatisticsData = _myTextService.CountStatistics(text);

            sw.Stop();

            TextPrintingData textPrintingData = _myTextService.FillPrintingData(textStatisticsData);

            _tb_AllSymbols.Text = textPrintingData.AllSymbolCount;
            _tb_UniqueItems.Text = textPrintingData.UniqueSymbolCount;
            _tb_Entropy.Text = textPrintingData.Entropy;
            _tb_Time.Text = sw.Elapsed.ToString();
            _dataGridView.Rows.Clear();
            for (int i = 0; i < textPrintingData?.SymbolStatistics?.Count; i++)
            {
                int index = _dataGridView.Rows.Add();
                _dataGridView.Rows[index].Cells[0].Value = textPrintingData.SymbolStatistics[i].BinaryNotation;
                _dataGridView.Rows[index].Cells[1].Value = textPrintingData.SymbolStatistics[i].DecimalNotation;
                _dataGridView.Rows[index].Cells[2].Value = textPrintingData.SymbolStatistics[i].Symbol;
                _dataGridView.Rows[index].Cells[3].Value = textPrintingData.SymbolStatistics[i].Frequency;
                _dataGridView.Rows[index].Cells[4].Value = textPrintingData.SymbolStatistics[i].Probability;
                _dataGridView.Rows[index].Cells[5].Value = textPrintingData.SymbolStatistics[i].InformationQuantity;
            }
        }
    }
}