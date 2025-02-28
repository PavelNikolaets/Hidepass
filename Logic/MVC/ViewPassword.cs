
using Hidepass.ObjectTemplates;
using Hidepass.Logic.FileOperations;

namespace Hidepass.Logic.MVC
{
    internal class ViewPassword
    {
        public static void DisplayBlocks(ListBox listBlocks, string path)
        {
            RootBlock blocks = JsonService.ToObject<RootBlock>(File.ReadAllText(path));

            listBlocks.Items.Clear();
            blocks.Blocks.ForEach(block => listBlocks.Items.Add(block.Name));
        }

        public static void DisplayCells(ListBox listCells, string path)
        {
            RootCell cells = JsonService.ToObject<RootCell>(File.ReadAllText(path));

            listCells.Items.Clear();
            cells.Cells.ForEach(cell => listCells.Items.Add(cell.Name));
        }
    }
}
