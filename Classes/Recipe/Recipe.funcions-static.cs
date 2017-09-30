using Ionic.Crc;
using Ionic.Zip;
using Newtonsoft.Json;

namespace Planar.Classes
{
    public partial class Recipe
    {
        public static Recipe Load(string Name)
        {
            ZipFile file = ZipFile.Read($@"recipes\{Name}.planar");
            ZipEntry entry = file["config.json"];
            string content = ZipEntryRead(entry);
            return JsonConvert.DeserializeObject<Recipe>(content);
        }

        private static string ZipEntryRead(ZipEntry entry)
        {
            CrcCalculatorStream reader = entry.OpenReader();
            string content = "";
            while (reader.Position < reader.Length)
            {
                content += (char)reader.ReadByte();
            }
            return content;
        }
    }
}
