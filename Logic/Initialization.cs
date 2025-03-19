
using Hidepass.Logic.MVC;
using File = System.IO.File;
using Directory = System.IO.Directory;

namespace Hidepass.Logic
{
    internal class Initialization
    {
        public static void ComponentsCheck(string dirPath, string fileMetadata)
        {
            if (Directory.Exists(dirPath) == false)
            {
                Directory.CreateDirectory(dirPath) ;
            }

            if (File.Exists(fileMetadata) == false)
            {
                File.Create(fileMetadata).Close();
            }
        }

        public static void InitDisplay(string metadata)
        {
            if (File.ReadAllText(metadata) != "")
            {
                ViewPassword.DisplayBlocks(Main.GListBlocks, metadata, Main.CurrentMasterKey);
            }
        }
    }
}
