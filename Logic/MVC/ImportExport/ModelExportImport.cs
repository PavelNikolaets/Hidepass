
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.OperationCryptography;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.ImportExport
{
    class ModelExportImport
    {
        public static void ModelExport(string fileName, BlockObject block, RootCell cell, string key)
        {
            string text = ImportExportService.ExportPassword(block, cell, key);

            File.WriteAllText(fileName, text);
        }

        public static void ModelImport(string fileName, string key)
        {
            string text = CryptographyModule.Decrypt(File.ReadAllText(fileName), key);

            ImportExportPassword obj = JsonService.ToObject<ImportExportPassword>(text);

            ImportExportService.ImportPassword(obj);
        }
    }
}