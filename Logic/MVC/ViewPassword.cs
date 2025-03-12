
using Hidepass.Logic.OperationCryptography;
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

            if (blocks.Blocks.Count > 0)
            {
                blocks.Blocks.ForEach(block => listBlocks.Items.Add(block.Name));
            }
        }

        public static void DisplayCells(ListBox listCells, string path)
        {
            RootCell cells = JsonService.ToObject<RootCell>(File.ReadAllText(path));

            listCells.Items.Clear();

            if (cells.Cells.Count > 0)
            {
                cells.Cells.ForEach(cell => listCells.Items.Add(cell.Name));
            }
        }

        public static void DisplayLabelDescription(Label label, int index)
        {
            if (index >= 0)
            {
                RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GPathToFileMetadata));

                if (obj.Blocks.Count > 0)
                {
                    string description = obj.Blocks[index].Description;
                    label.Text = $"Описание:\n{description}";
                }
                else
                {
                    label.Text = $"Описание:\n";
                }

            }
        }
    }
}
