using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Leads 
{
    public class LeadDays
    {
        /// <summary>
        /// Impressions number
        /// </summary>
        [JsonProperty("impressions")]
        public int? Impressions { get; set; }

        /// <summary>
        /// Completed offers number
        /// </summary>
        [JsonProperty("completed")]
        public int? Completed { get; set; }

        /// <summary>
        /// Started offers number
        /// </summary>
        [JsonProperty("started")]
        public int? Started { get; set; }

        /// <summary>
        /// Amount of spent votes
        /// </summary>
        [JsonProperty("spent")]
        public int? Spent { get; set; }

    }
}