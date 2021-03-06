using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API User object.
    /// </summary>
    public class User : UserMin
    {
        /// <summary>
        /// User sex
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }

        /// <summary>
        /// URL of square photo of the user with 50 pixels in width
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// Information whether the user is online
        /// </summary>
        [JsonProperty("online")]
        public int? Online { get; set; }

        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        /// <summary>
        /// URL of square photo of the user with 100 pixels in width
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }
    }
}