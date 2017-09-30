using Planar.Enums;

namespace Planar.Classes
{
    public partial class Script
    {
        public Script(string Name, string Content, TargetPlatform platform = TargetPlatform.UNKNOWN, TargetOS os = TargetOS.UNKNOWN, TargetArch arch = TargetArch.UNKNOWN)
        {
            scriptName = Name;
            scriptBody = Content;

            this.platform = platform;
            this.os = os;
            this.arch = arch;
        }
    }
}
