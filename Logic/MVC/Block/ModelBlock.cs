
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Block
{
    internal class ModelBlock
    {
        public static void ModelCreateBlock(string name, string description, string pathToBlock)
        {
            string jsonMeta = File.ReadAllText(Main.GlobalPathToFileMetadata);
            RootBlock obj = new();

            if (jsonMeta != "")
            {
                obj = JsonService.ToObject<RootBlock>(jsonMeta);
            }

            obj.Blocks.Add(new(name, description, pathToBlock));

            File.Create(pathToBlock).Close();
            File.WriteAllText(Main.GlobalPathToFileMetadata, JsonService.ToJson(obj));

            MessageBox.Show("Блок создан!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ModelDeleteBlock(string pathToBlock, int index)
        {


            File.Delete(pathToBlock);
        }
    }
}
