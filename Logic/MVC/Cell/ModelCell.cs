
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Cell
{
    internal class ModelCell
    {
        public static void ModelCreateCell(string name, string description, string login, string password, string path)
        {
            string json = File.ReadAllText(path);
            RootCell obj = new();

            if (json != "" )
            {
                obj = JsonService.ToObject<RootCell>(json);
            }

            obj.Cells.Add(new(name, description, login, password));

            File.WriteAllText(path, JsonService.ToJson(obj));

            MessageBox.Show("Ячейка создана!", "Выполнено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
