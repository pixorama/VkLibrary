using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class StatsSexAge
    {
        /// <summary>
        /// Impressions rate
        /// </summary>
        [JsonProperty("impressions_rate")]
        public uint? ImpressionsRate { get; set; }

        /// <summary>
        /// Sex and age interval
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Clicks rate
        /// </summary>
        [JsonProperty("clicks_rate")]
        public uint? ClicksRate { get; set; }

    }
}