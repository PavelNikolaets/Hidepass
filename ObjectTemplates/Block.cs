
using System.Text.Json.Serialization;

namespace Hidepass.ObjectTemplates
{
    internal class RootBlock
    {
        [JsonPropertyName("Blocks")]
        public List<BlockObject> Blocks { get; set; } = [];
    }

    internal class BlockObject(string name, string description, string pathToFile)
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; } = name;
        [JsonPropertyName("Description")]
        public string Description { get; set; } = description;
        [JsonPropertyName("PathToFile")]
        public string PathToFile { get; set; } = pathToFile;
    }
}
