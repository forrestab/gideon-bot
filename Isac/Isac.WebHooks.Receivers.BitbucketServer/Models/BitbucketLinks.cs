﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Isac.WebHooks.Receivers.BitbucketServer.Models
{
    public class BitbucketLinks
    {
        // TODO, define this
        [JsonProperty("self")]
        public List<JObject> Self { get; set; }
    }
}
