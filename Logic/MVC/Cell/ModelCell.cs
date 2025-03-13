
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.OperationCryptography;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Cell
{
    internal class ModelCell
    {
        public static void ModelCreateCell(string name, string description, string login, string password, string path)
        {
            string encryptedJson = File.ReadAllText(path);
            string json = encryptedJson != "" ? CryptographyModule.Decrypt(encryptedJson) : "";
            RootCell obj = json != "" ? JsonService.ToObject<RootCell>(json) : new();

            obj.Cells.Add(new(name, description, login, password));

            string outputJson = JsonService.ToJson(obj);
            File.WriteAllText(path, CryptographyModule.Encrypt(outputJson));

            ViewPassword.DisplayCells(Main.GListCells, path);
        }

        public static void ModelDeleteCell(string path, int index)
        {
            string encryptedJson = File.ReadAllText(path);
            string json = CryptographyModule.Decrypt(encryptedJson);
            RootCell obj = JsonService.ToObject<RootCell>(json);
            obj.Cells.RemoveAt(index);

            File.WriteAllText(path, CryptographyModule.Encrypt(JsonService.ToJson(obj)));

            ViewPassword.DisplayCells(Main.GListCells, path);
        }

        public static void ModelChangeCell(string path, int index, string name, string description, string login, string password)
        {
            string encryptedJson = File.ReadAllText(path);
            string json = CryptographyModule.Decrypt(encryptedJson);
            RootCell obj = JsonService.ToObject<RootCell>(json);

            obj.Cells[index].Name = name;
            obj.Cells[index].Description = description;
            obj.Cells[index].Login = login;
            obj.Cells[index].Password = password;
            obj.Cells[index].DateUpdate = DateTime.Now.ToString("g");

            File.WriteAllText(path, CryptographyModule.Encrypt(JsonService.ToJson(obj)));
            ViewPassword.DisplayCells(Main.GListCells, path);
        }
    }
}
