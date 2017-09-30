using Newtonsoft.Json;
using Planar.Enums;

namespace Planar.Classes
{
    public partial class Script
    {
        [JsonProperty] string scriptName;
        [JsonProperty] TargetPlatform platform;
        [JsonProperty] TargetOS os;
        [JsonProperty] TargetArch arch;
        [JsonIgnore] string scriptBody;
    }
}
