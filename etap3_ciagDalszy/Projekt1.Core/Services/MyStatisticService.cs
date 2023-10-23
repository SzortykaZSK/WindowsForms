using Projekt1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1.Core.Services
{
    internal class MyStatisticService : BaseTextStatisticsService
    {
        public override TextStatisticsData CountStatistics(string text)
        {
            TextStatisticsData data = new TextStatisticsData();
        
            data.AllSymbolCount = text.Length;
            data.UniqueSymbolCount = uniqueSymbolCounter(text);
            //data.Entropy - nie skonczone 

            return data;
        }

        public int uniqueSymbolCounter(string text)
        {
            List<char> unigueCharacter = new List<char>();

            foreach(char c in text)
            {
                if (!unigueCharacter.Contains(c))
                {
                    unigueCharacter.Add(c);
                }
            }
            int res = unigueCharacter.Count;
            return res;
        }
    }
}
