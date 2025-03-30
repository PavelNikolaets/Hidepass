
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;

namespace Hidepass.Logic.MVC.Block
{
    internal class ControllerBlock
    {
        public static void ControllerCreateBlock(string name, string description, string key, string pathToBlock)
        {
            string[] paramAll = [name, pathToBlock];
            if (paramAll.All(p => p != ""))
            {
                if (name.Contains('\\') == false)
                {
                    string path = $@"{Main.GPathToDir}\{name}.json";

                    if (File.Exists(path) == false)
                    {
                        ModelBlock.ModelCreateBlock(name, description, key, pathToBlock);
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете создавать блоки с одинаковым названием!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ControllerDeleteBlock(string pathToBlock, int index, string key)
        {
            if (Path.Exists(pathToBlock) && index >= 0)
            {
                ModelBlock.ModelDeleteBlock(pathToBlock, index, key);
            }
        }

        public static void ControllerChangeBlock(int index, string name, string description, string key)
        {
            RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GPathToFileMetadata));

            if (obj.Blocks.Count >= index)
            {
                ModelBlock.ModelChangeBlock(index, name, description, key);
            }
        }
    }
}
