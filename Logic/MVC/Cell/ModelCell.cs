
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
            RootCell obj = json != "" ? JsonService.ToObject<RootCell>(json) : new();

            obj.Cells.Add(new(name, description, login, password));

            File.WriteAllText(path, JsonService.ToJson(obj));

            ViewPassword.DisplayCells(Main.GListCells, path);
        }

        public static void ModelDeleteCell(string path, int index)
        {
            RootCell obj = JsonService.ToObject<RootCell>(File.ReadAllText(path));
            obj.Cells.RemoveAt(index);

            File.WriteAllText(path, JsonService.ToJson(obj));

            ViewPassword.DisplayCells(Main.GListCells, path);
        }

        public static void ModelChangeCell(string path, int index, string name, string description, string login, string password)
        {
            RootCell obj = JsonService.ToObject<RootCell>(File.ReadAllText(path));

            obj.Cells[index].Name = name;
            obj.Cells[index].Description = description;
            obj.Cells[index].Login = login;
            obj.Cells[index].Password = password;
            obj.Cells[index].DateUpdate = DateTime.Now.ToString("g");

            File.WriteAllText(path, JsonService.ToJson(obj));

            ViewPassword.DisplayCells(Main.GListCells, path);
        }
    }
}
