using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Secure 
{
    public class SmsNotification
    {
        /// <summary>
        /// Messsage text
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId_ { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("app_id")]
        public int? AppId_ { get; set; }

        /// <summary>
        /// Notification ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Date when message has been sent in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

    }
}