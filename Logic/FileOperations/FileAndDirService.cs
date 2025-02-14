using File = System.IO.File;
using Dir = System.IO.Directory;
using System.Text.Json;

namespace Hidepass.Logic.FileOperations
{
    internal class FileAndDirService
    {
        public void CreateDir(string path)
        {
            if (Dir.Exists(path) == false)
            {
                Dir.CreateDirectory(path);
            }
        }

        public void CreateJSON(string path)
        {
            if(File.Exists(path) == false)
            {
                File.Create(path);
            }
        }

        public void WriteOnFile(string path, string[] input)
        {

        }
    }
}
