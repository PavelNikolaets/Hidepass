
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.OperationCryptography;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Cell
{
    internal class ModelCell
    {
        public static void ModelCreateCell(string name, string description, string login, string password, string key, string dateCreate, string path, string dateUpdate = "")
        {
            string encryptedJson = File.Exists(path) ? File.ReadAllText(path) : "";
            try
            {
                string json = encryptedJson != "" ? CryptographyModule.Decrypt(encryptedJson, key) : "";

                RootCell obj = json != "" ? JsonService.ToObject<RootCell>(json) : new(key);

                obj.Cells.Add(new(name, description, login, password, dateCreate, dateUpdate));

                string outputJson = JsonService.ToJson(obj);
                File.WriteAllText(path, CryptographyModule.Encrypt(outputJson, key));

                ViewPassword.DisplayCells(Main.GListCells, path, key);
            }
            catch
            {
                return;   
            }
        }

        public static void ModelDeleteCell(string path, int index, string key)
        {
            string encryptedJson = File.ReadAllText(path);
            try
            {
                string json = CryptographyModule.Decrypt(encryptedJson, key);
                RootCell obj = JsonService.ToObject<RootCell>(json);
                obj.Cells.RemoveAt(index);

                File.WriteAllText(path, CryptographyModule.Encrypt(JsonService.ToJson(obj), key));

                ViewPassword.DisplayCells(Main.GListCells, path, key);
            }
            catch
            {
                return;
            }
            
        }

        public static void ModelChangeCell(string path, int index, string name, string description, string login, string password, string key)
        {
            string encryptedJson = File.ReadAllText(path);
            try
            {
                string json = CryptographyModule.Decrypt(encryptedJson, key);
                RootCell obj = JsonService.ToObject<RootCell>(json);

                obj.Cells[index].Name = name;
                obj.Cells[index].Description = description;
                obj.Cells[index].Login = login;
                obj.Cells[index].Password = password;
                obj.Cells[index].DateUpdate = DateTime.Now.ToString("g");

                File.WriteAllText(path, CryptographyModule.Encrypt(JsonService.ToJson(obj), key));
                ViewPassword.DisplayCells(Main.GListCells, path, key);
            }
            catch
            {
                return;
            }
            
        }
    }
}
