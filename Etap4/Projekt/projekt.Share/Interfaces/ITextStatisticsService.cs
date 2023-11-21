using projekt.Shared.Entities;

namespace projekt.Shared.Interfaces
{
    public interface ITextStatisticsService
    {
        TextStatisticsData CountStatistics(string text);

        TextPrintingData FillPrintingData(TextStatisticsData statistics);
    }
}
