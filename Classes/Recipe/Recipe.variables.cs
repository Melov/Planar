using Newtonsoft.Json;
using System.Collections.Generic;

namespace Planar.Classes
{
    public partial class Recipe
    {
        [JsonProperty] string name;
        [JsonProperty] Config config;
        [JsonProperty] List<Script> scripts;
    }
}
