using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class LikesInfo
    {
        /// <summary>
        /// Information whether current user can like the post
        /// </summary>
        [JsonProperty("can_like")]
        public int? CanLike_ { get; set; }

        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current uer has liked the post
        /// </summary>
        [JsonProperty("user_likes")]
        public int? UserLikes_ { get; set; }

        /// <summary>
        /// Information whether current user can repost
        /// </summary>
        [JsonProperty("can_publish")]
        public int? CanPublish_ { get; set; }

    }
}