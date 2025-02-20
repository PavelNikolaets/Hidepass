
namespace Hidepass.ObjectTemplates
{
    internal class BlockPassword(/*int id, string name, string description*/)
    {
        //public int Id { get; } = id;
        //public string Name { get; set; }
        //public string Description { get; set; }
        public List<CellPassword> CellsPasswords { get; set; } = [];
    }
}
