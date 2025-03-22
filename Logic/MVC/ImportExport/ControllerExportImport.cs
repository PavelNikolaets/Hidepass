using Hidepass.ObjectTemplates;

namespace Hidepass.Logic.MVC.ImportExport
{
    class ControllerExportImport
    {
        public static void ControllerImport(string fileName)
        {
            ModelExportImport.ModelImport(fileName);
        }

        public static void ControllerExport(string fileName, BlockObject block, RootCell cell, string key)
        {
            ModelExportImport.ModelExport(fileName, block, cell, key);
        }
    }
}
