using System.Collections.Generic;

namespace Planar.Classes
{
    public partial class Recipe
    {
        public List<Script> Scripts => scripts;
        public Config Config => Config;
        public string Name => name;
    }
}
