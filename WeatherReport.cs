using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherMicroservice
{
    public class WeatherReport
    {
        private static readonly string[] PossibleConditions = new string[]
        {
            "Sunny",
            "Mostly Sunny",
            "Partly Sunny",
            "Partly Cloudy",
            "Mostly Cloudy",
            "Rain"
        };

        public int HiTemperature { get; }
        public int LoTemperature { get; }
        public int AverageWindSpeed { get; }
        public string Conditions { get; }
    }
}
