using projekt.Core.Services;
using projekt.Shared.Entities;

namespace projekt.Core.Services
{
    public class TextStatisticsSevice : BaseTextStatisticsService
    {
        public override TextStatisticsData CountStatistics(string text)
        {

            TextStatisticsData result = new TextStatisticsData();
            result.AllSymbolCount = text.Length;
            result.UniqueSymbolCount = 0;
            result.Entropy = 0;
            result.SymbolStatistics = new List<SymbolStatisticsData>();


            Dictionary<char, SymbolStatisticsData> stats = new Dictionary<char, SymbolStatisticsData>();
            for (int i = 0; i < text.Length; i++)
            {

                SymbolStatisticsData? symbol;
                if (!stats.TryGetValue(text[i], out symbol))
                {

                    symbol = new SymbolStatisticsData();
                    symbol.Symbol = text[i];
                    symbol.Frequency = 0;

                    result.SymbolStatistics.Add(symbol);
                    stats.Add(text[i], symbol);
                }

                symbol.Frequency++;
            }

            result.UniqueSymbolCount = result.SymbolStatistics.Count;
            for (int i = 0; i < result.SymbolStatistics.Count; i++)
            {
                result.SymbolStatistics[i].Probability =
                    (double)result.SymbolStatistics[i].Frequency /
                    (double)result.AllSymbolCount;

                result.SymbolStatistics[i].InformationQuantity =
                    Math.Log((1d / result.SymbolStatistics[i].Probability), 2);

                result.Entropy +=
                    result.SymbolStatistics[i].Probability *
                    result.SymbolStatistics[i].InformationQuantity;
            }

            return result;
        }
    }
}