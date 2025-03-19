
namespace Hidepass.ObjectTemplates
{
    class ImportExportPassword(BlockObject block, List<CellObject> cells, string key)
    {
        public BlockObject BlockInfo { get; set; } = block;
        public string MasterKey { get; set; } = key;
        public List<CellObject> Cell { get; set; } = cells;
    }
}
