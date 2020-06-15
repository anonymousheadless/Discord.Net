using Newtonsoft.Json;

namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class CreateGuildRoleParams
    {
        [JsonProperty("name")]
        public Optional<string> Name { get; set; }
        [JsonProperty("permissions")]
        public Optional<ulong> Permissions { get; set; }
        [JsonProperty("color")]
        public Optional<uint> Color { get; set; }
        [JsonProperty("hoist")]
        public Optional<bool> Hoist { get; set; }
        [JsonProperty("mentionable")]
        public Optional<bool> Mentionable { get; set; }
    }
    }
