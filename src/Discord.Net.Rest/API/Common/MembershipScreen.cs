using System;
using Newtonsoft.Json;


namespace Discord.API
{
    internal class MembershipScreen
    {
        [JsonProperty("version")]
        public DateTimeOffset Version { get; set; }

        [JsonProperty("form_fields")]
        public MembershipScreenField[] FormFields { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
