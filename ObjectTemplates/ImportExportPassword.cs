
namespace Hidepass.ObjectTemplates
{
    class ImportExportPassword(BlockObject blockInfo, List<CellObject> cells, string masterKey)
    {
        public BlockObject BlockInfo { get; set; } = blockInfo;
        public string MasterKey { get; set; } = masterKey;
        public List<CellObject> Cells { get; set; } = cells;
    }
}
