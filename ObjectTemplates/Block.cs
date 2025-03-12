
namespace Hidepass.ObjectTemplates
{
    public class RootBlock
    {
        public List<BlockObject> Blocks { get; set; } = [];
    }

    public class BlockObject(string name, string description, string pathToFile)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string PathToFile { get; set; } = pathToFile;
    }
}
