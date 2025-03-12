
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;

namespace Hidepass.Logic.MVC.Block
{
    internal class ControllerBlock
    {
        public static void ControllerCreateBlock(string name, string description, string pathToBlock)
        {
            string[] paramAll = [name, pathToBlock];
            if (paramAll.All(p => p != ""))
            {
                if (name.Contains('\\') == false)
                {
                    ModelBlock.ModelCreateBlock(name, description, pathToBlock);
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ControllerDeleteBlock(string pathToBlock, int index)
        {
            if (Path.Exists(pathToBlock) && index >= 0)
            {
                ModelBlock.ModelDeleteBlock(pathToBlock, index);
            }
        }

        public static void ControllerChangeBlock(int index, string name, string description)
        {
            if (JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GPathToFileMetadata)).Blocks.Count >= index)
            {
                ModelBlock.ModelChangeBlock(index, name, description);
            }
        }
    }
}
