using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class CountersGroup
    {
        /// <summary>
        /// Photos number
        /// </summary>
        [JsonProperty("photos")]
        public int? Photos { get; set; }

        /// <summary>
        /// Topics number
        /// </summary>
        [JsonProperty("topics")]
        public int? Topics { get; set; }

        /// <summary>
        /// Market items number
        /// </summary>
        [JsonProperty("market")]
        public int? Market { get; set; }

        /// <summary>
        /// Photo albums number
        /// </summary>
        [JsonProperty("albums")]
        public int? Albums { get; set; }

        /// <summary>
        /// Audios number
        /// </summary>
        [JsonProperty("audios")]
        public int? Audios { get; set; }

        /// <summary>
        /// Docs number
        /// </summary>
        [JsonProperty("docs")]
        public int? Docs { get; set; }

        /// <summary>
        /// Videos number
        /// </summary>
        [JsonProperty("videos")]
        public int? Videos { get; set; }

    }
}