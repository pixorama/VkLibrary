using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class DemoStats
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("stats")]
        public VkLib.Types.Ads.DemostatsFormat Stats { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}