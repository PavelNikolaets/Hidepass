
using File = System.IO.File;
using Dir = System.IO.Directory;

namespace Hidepass.Logic.FileOperations
{
    internal class FileAndDirService
    {
        public static void CreateDir(string path)
        {
            if (Dir.Exists(path) == false)
            {
                Dir.CreateDirectory(path);
            }
        }

        public static void DeleteDir(string path)
        {
            if (Dir.Exists(path))
            {
                Dir.Delete(path);
            }
        }

        public static void CreateFile(string path)
        {
            if(File.Exists(path) == false)
            {
                File.Create(path);
            }
        }

        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public static void WriteOnFile(string path, string input)
        {
            if(File.Exists(path))
            {
                File.WriteAllText(path, input);
            }
        }

        public static string ReadFile(string path)
        {
            if(File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return "";
        }
    }
}
