
namespace Hidepass.ObjectTemplates
{
    internal class RootBlock
    {
        public List<BlockObject> Blocks { get; set; } = [];
    }

    internal class BlockObject(string name, string description, string pathToFile)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string PathToFile { get; set; } = pathToFile;
    }
}
