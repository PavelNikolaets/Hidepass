
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Block
{
    internal class ControllerBlock
    {
        public static void ControlCreateBlock(string name, string description)
        {
            if (name != "" && description != "")
            {
                ListBlocks obj = new();
                obj.BlocksMetadata.Add(new(name, description, Main.GlobalPathToFile));

                if (File.Exists(Main.GlobalPathToFile))
                {
                    ListBlocks readObj = JsonService.ToObject<ListBlocks>(File.ReadAllText(Main.GlobalPathToFile));
                    obj.BlocksMetadata = readObj.BlocksMetadata;
                }

                File.WriteAllText(Main.GlobalPathToFile, JsonService.ToJson(obj));
                ModelBlock.ModelCreateBlock(name, description);
            }
            else
            {
                MessageBox.Show("Не введено название или описание!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
