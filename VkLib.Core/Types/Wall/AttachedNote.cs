using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Wall 
{
    public class AttachedNote
    {
        /// <summary>
        /// Read comments number
        /// </summary>
        [JsonProperty("read_comments")]
        public int? ReadComments_ { get; set; }

        /// <summary>
        /// Note owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId_ { get; set; }

        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// URL of the page with note preview
        /// </summary>
        [JsonProperty("view_url")]
        public string ViewUrl_ { get; set; }

        /// <summary>
        /// Date when the note has been created in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Note title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Note ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}