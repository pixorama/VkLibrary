using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Friends
{
    /// <summary>
    /// API FriendStatus object.
    /// </summary>
    public class FriendStatus
    {
        /// <summary>
        /// MD5 hash for the result validation
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// Information whether request is unviewed
        /// </summary>
        [JsonProperty("read_state")]
        public int? ReadState { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Message sent with request
        /// </summary>
        [JsonProperty("request_message")]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Friend status with the user
        /// </summary>
        [JsonProperty("friend_status")]
        public int? FriendStatusCode { get; set; }
    }
}