
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
            RootBlock obj = jsonMeta != "" ? JsonService.ToObject<RootBlock>(jsonMeta) : new();

            obj.Blocks.Add(new(name, description, pathToBlock));

            File.Create(pathToBlock).Close();
            File.WriteAllText(Main.GlobalPathToFileMetadata, JsonService.ToJson(obj));

            MessageBox.Show("Блок создан!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ModelDeleteBlock(string pathToBlock, int index)
        {
            RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GlobalPathToFileMetadata));
            obj.Blocks.RemoveAt(index);

            File.WriteAllText(Main.GlobalPathToFileMetadata, JsonService.ToJson(obj));
            File.Delete(pathToBlock);

            MessageBox.Show("Блок удален!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ModelChangeBlock(int index, string name, string description)
        {
            RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GlobalPathToFileMetadata));

            obj.Blocks[index].Name = name;
            obj.Blocks[index].Description = description;

            File.WriteAllText(Main.GlobalPathToFileMetadata, JsonService.ToJson(obj));

            MessageBox.Show("Блок изменен!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
