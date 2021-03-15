using System.Collections.Generic;
using Newtonsoft.Json;


namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class ModifyGuildMembershipScreenParams
    {
        [JsonProperty("enabled")]
        public Optional<bool> Enabled { get; set; }

        public Optional<IEnumerable<MembershipScreenField>> FormFields { get; set; }

        [JsonProperty("description")]
        public Optional<string> Description { get; set; }

        [JsonProperty("form_fields")]
        internal Optional<string> _formFields { get; set; }
    }
}
