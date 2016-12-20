using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Audio 
{
    public class AudioFull : VkLib.Types.Audio.Audio
    {
        /// <summary>
        /// Date when uploaded
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Information whether the audio is hidden from search
        /// </summary>
        [JsonProperty("no_search")]
        public int? NoSearch_ { get; set; }

        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId_ { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Genre ID
        /// </summary>
        [JsonProperty("genre_id")]
        public int? GenreId_ { get; set; }

        /// <summary>
        /// Lyrics ID
        /// </summary>
        [JsonProperty("lyrics_id")]
        public int? LyricsId_ { get; set; }

    }
}