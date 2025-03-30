
using Hidepass.ObjectTemplates;
using Hidepass.Logic.OperationCryptography;
using Hidepass.Logic.MVC.Block;
using Hidepass.Logic.MVC.Cell;

namespace Hidepass.Logic.FileOperations
{
    class ImportExportService
    {
        public static void ImportPassword(ImportExportPassword importPassword)
        {
            try
            {
                BlockObject blockObj = importPassword.BlockInfo;

                ControllerBlock.ControllerCreateBlock(blockObj.Name, blockObj.Description, importPassword.MasterKey, blockObj.PathToFile);
                importPassword.Cells.ForEach(cell => ControllerCell.ControllerCreateCell(cell.Name, cell.Description, cell.Login, cell.Password, blockObj.PathToFile, cell.DateCreate, importPassword.MasterKey, cell.DateUpdate));
            }
            catch
            {
                MessageBox.Show($"Произошла ошибка при импорте!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string ExportPassword(BlockObject block, RootCell cell, string key)
        {
            ImportExportPassword exportPassword = new(block, cell.Cells, key);

            string json = JsonService.ToJson(exportPassword);
            return CryptographyModule.Encrypt(json, key);
        }
    }
}
