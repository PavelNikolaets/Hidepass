
namespace Hidepass.Logic.MVC.Cell
{
    internal class ControllerCell
    {
        public static void ControlCreateCell(string name, string description, string login, string password, string path)
        {
            if (name != "" && description != "" && login != "" && password != "" && path != "")
            {
                ModelCell.ModelCreateCell(name, description, login, password, path);
            }
        }
    }
}
