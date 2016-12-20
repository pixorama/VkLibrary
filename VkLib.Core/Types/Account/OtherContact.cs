using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Account 
{
    public class OtherContact
    {
        /// <summary>
        /// Mutual friends count
        /// </summary>
        [JsonProperty("common_count")]
        public int? CommonCount_ { get; set; }

        /// <summary>
        /// Contact
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; set; }

    }
}