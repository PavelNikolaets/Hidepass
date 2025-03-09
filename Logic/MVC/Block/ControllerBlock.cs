
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using static Hidepass.ObjectTemplates.EnumObject;

namespace Hidepass.Logic.MVC.Block
{
    internal class ControllerBlock
    {
        public static void ControlCreateBlock(string name, string description, string pathToBlock)
        {
            string[] paramAll = [name, pathToBlock];
            if (paramAll.All(p => p != ""))
            {
                ModelBlock.ModelCreateBlock(name, description, pathToBlock);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ControllerDeleteBlock(string pathToBlock, int index)
        {
            if (Path.Exists(pathToBlock))
            {
                ModelBlock.ModelDeleteBlock(pathToBlock, index);
            }
        }

        public static void ControllerChangeBlock(int index, string name, string description)
        {
            if (JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GlobalPathToFileMetadata)).Blocks.Count >= index)
            {
                ModelBlock.ModelChangeBlock(index, name, description);
            }
        }
    }
}
