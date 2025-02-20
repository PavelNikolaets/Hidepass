
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;

namespace Hidepass.Logic.MVC.Cell
{
    internal class ModelCell
    {
        public static void ModelCreateCell(string name, string description, string login, string password, string path)
        {
            CellPassword objCell = new(name, description, login, password);
            ListBlocks objBlockRead = JsonService.ToObject<ListBlocks>(File.ReadAllText(path));

            objBlockRead.CellsPasswords.Add(objCell);

            File.WriteAllText(JsonService.ToJson(objBlockRead), path);
        }
    }
}
