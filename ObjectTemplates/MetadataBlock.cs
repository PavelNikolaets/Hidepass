
namespace Hidepass.ObjectTemplates
{
    internal class MetadataBlock(string name, string description, string path)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string PathToFile { get; set; } = path;
        public Icon Icon { get; set; }
    }
}
