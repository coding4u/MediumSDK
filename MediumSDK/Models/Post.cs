﻿using Newtonsoft.Json;
using System;
using MediumSDK.Utils;

namespace MediumSDK.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string PublicationId { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string[] Tags { get; set; }
        public string Url { get; set; }
        public string CanonicalUrl { get; set; }
        public PublishStatus PublishStatus { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? PublishedAt { get; set; }
        [JsonConverter(typeof(LicenseEnumConverter))]
        public License License { get; set; }
        public string LicenseUrl { get; set; }
    }
}
