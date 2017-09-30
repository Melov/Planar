using Ionic.Zip;
using Newtonsoft.Json;
using Planar.Enums;
using System.Collections.Generic;
using System.IO;

namespace Planar.Classes
{
    public partial class Recipe
    {
        public Recipe(string Name, TargetPlatform platform = TargetPlatform.UNKNOWN, TargetOS OS = TargetOS.UNKNOWN)
        {
            name = Name;
            config = new Config(platform, OS);
            scripts = new List<Script>();
        }

        public void AddScript(string Name, string FileLocation)
        {
            string scriptContent = File.ReadAllText(FileLocation);
            scripts.Add(new Script(Name, scriptContent));
        }

        public void Save()
        {
            ZipFile file = new ZipFile();
            file.AddEntry("config.json", JsonConvert.SerializeObject(this));
            foreach (Script s in scripts)
            {
                file.AddEntry($@"scripts\{s.Name}.sh", s.Content);
            }
            file.Save($@"recipes\{name}.planar");
        }
    }
}
