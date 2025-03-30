
using Hidepass.Logic.OperationCryptography;
using Hidepass.ObjectTemplates;
using Hidepass.Logic.FileOperations;

namespace Hidepass.Logic.MVC
{
    internal class ViewPassword
    {
        public static void DisplayBlocks(ListBox listBlocks, string path, string key)
        {
            RootBlock blocks = JsonService.ToObject<RootBlock>(File.ReadAllText(path));

            listBlocks.Items.Clear();

            if (blocks.Blocks.Count > 0)
            {
                blocks.Blocks.ForEach(block => listBlocks.Items.Add(block.Name));
            }
        }

        public static void DisplayCells(ListBox listCells, string path, string key)
        {
            string encryptedJson = File.ReadAllText(path);
            try
            {
                string json = CryptographyModule.Decrypt(encryptedJson, key);
                RootCell cells = JsonService.ToObject<RootCell>(json);

                listCells.Items.Clear();

                if (cells.Cells.Count > 0 )
                {
                    cells.Cells.ForEach(cell => listCells.Items.Add(cell.Name));
                }
            }
            catch (Exception)
            {
                return;
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
