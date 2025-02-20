
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Block
{
    internal class ModelBlock
    {
        public static void ModelCreateBlock(string name, string description)
        {
            string pathToFile = @$"{Main.GlobalPathToDir}\{name}.json";
            
            File.WriteAllText(pathToFile, JsonService.ToJson(new BlockPassword()));

            MessageBox.Show("Блок создан!");
        }
    }
}
