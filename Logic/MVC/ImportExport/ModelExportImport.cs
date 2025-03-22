
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.OperationCryptography;
using Hidepass.ObjectTemplates;
using Microsoft.VisualBasic;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.ImportExport
{
    class ModelExportImport
    {
        public static void ModelExport(string fileName, BlockObject block, RootCell cell, string key)
        {
            File.WriteAllText(fileName, ImportExportService.ExportPassword(block, cell, key));
        }

        public static void ModelImport(string fileName)
        {
            string key = Interaction.InputBox("Введите ключ от этого блока", "Ввод ключа", "");
            string text = CryptographyModule.Decrypt(File.ReadAllText(fileName), key);
            ImportExportPassword obj = JsonService.ToObject<ImportExportPassword>(text);
            ImportExportService.ImportPassword(obj);
        }
    }
}