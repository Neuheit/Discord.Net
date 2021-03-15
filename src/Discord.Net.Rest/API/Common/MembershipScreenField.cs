using Discord;
using Newtonsoft.Json;

namespace Discord.API
{
    internal class MembershipScreenField
    {
        [JsonProperty("field_type")]
        public string FieldType { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Optional<string[]> Values { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }
}
