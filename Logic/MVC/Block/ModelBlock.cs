
using Hidepass.Logic.OperationCryptography;
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Block
{
    internal class ModelBlock
    {
        public static void ModelCreateBlock(string name, string description, string pathToBlock)
        {
            string jsonMeta = File.ReadAllText(Main.GPathToFileMetadata);
            RootBlock obj = jsonMeta != "" ? JsonService.ToObject<RootBlock>(jsonMeta) : new();

            obj.Blocks.Add(new(name, description, pathToBlock));

            File.WriteAllText(pathToBlock, JsonService.ToJson<RootCell>(new()));
            File.WriteAllText(Main.GPathToFileMetadata, JsonService.ToJson(obj));

            ViewPassword.DisplayBlocks(Main.GListBlocks, Main.GPathToFileMetadata);
        }

        public static void ModelDeleteBlock(string pathToBlock, int index)
        {
            RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GPathToFileMetadata));
            obj.Blocks.RemoveAt(index);

            File.WriteAllText(Main.GPathToFileMetadata, JsonService.ToJson(obj));
            File.Delete(pathToBlock);

            Main.GListCells.Items.Clear();
            ViewPassword.DisplayBlocks(Main.GListBlocks, Main.GPathToFileMetadata);
        }

        public static void ModelChangeBlock(int index, string name, string description)
        {
            RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GPathToFileMetadata));

            obj.Blocks[index].Name = name;
            obj.Blocks[index].Description = description;

            File.WriteAllText(Main.GPathToFileMetadata, JsonService.ToJson(obj));

            ViewPassword.DisplayBlocks(Main.GListBlocks, Main.GPathToFileMetadata);
        }
    }
}
