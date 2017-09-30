using Newtonsoft.Json;
using Planar.Enums;

namespace Planar.Classes
{
    public partial class Config
    {
        [JsonProperty] TargetPlatform platform;
        [JsonProperty] TargetOS os;
    }
}
