using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Campaign object.
    /// </summary>
    public class Campaign
    {
        /// <summary>
        /// Campaign start time, as Unixtime
        /// </summary>
        [JsonProperty("start_time")]
        public double? StartTime { get; set; }

        /// <summary>
        /// Campaign status
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Campaign type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Campaign title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Campaign's total limit, rubles
        /// </summary>
        [JsonProperty("all_limit")]
        public string AllLimit { get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Campaign's day limit, rubles
        /// </summary>
        [JsonProperty("day_limit")]
        public string DayLimit { get; set; }

        /// <summary>
        /// Campaign stop time, as Unixtime
        /// </summary>
        [JsonProperty("stop_time")]
        public double? StopTime { get; set; }
    }
}