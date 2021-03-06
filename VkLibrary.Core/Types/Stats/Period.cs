using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Stats
{
    /// <summary>
    /// API Period object.
    /// </summary>
    public class Period
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex")]
        public IEnumerable<Sex> Sex { get; set; }

        /// <summary>
        /// Total reach
        /// </summary>
        [JsonProperty("reach")]
        public int? Reach { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("sex_age")]
        public IEnumerable<SexAge> SexAge { get; set; }

        /// <summary>
        /// Subscribers reach
        /// </summary>
        [JsonProperty("reach_subscribers")]
        public int? ReachSubscribers { get; set; }

        /// <summary>
        /// Day (YYYY-MM-DD)
        /// </summary>
        [JsonProperty("day")]
        public string Day { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("countries")]
        public IEnumerable<Country> Countries { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Views number
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }

        /// <summary>
        /// Number of users subscribed
        /// </summary>
        [JsonProperty("subscribed")]
        public int? Subscribed { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("cities")]
        public IEnumerable<City> Cities { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("age")]
        public IEnumerable<Age> Age { get; set; }

        /// <summary>
        /// Number of users unsubscribed
        /// </summary>
        [JsonProperty("unsubscribed")]
        public int? Unsubscribed { get; set; }
    }
}