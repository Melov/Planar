using Newtonsoft.Json;
using Planar.Enums;

namespace Planar.Classes
{
    public partial class Script
    {
        [JsonIgnore] public string Name => scriptName;
        [JsonIgnore] public string Content => scriptBody;
        [JsonIgnore] public TargetPlatform Platform => platform;
        [JsonIgnore] public TargetOS OS => os;
        [JsonIgnore] public TargetArch Arch => arch;
    }
}
