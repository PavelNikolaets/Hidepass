
namespace Hidepass.Logic.MVC.Cell
{
    internal class ControllerCell
    {
        public static void ControlCreateCell(string name, string description, string login, string password, string path)
        {
            string[] paramAll = [name, login, password, path];
            if (paramAll.All(p => p != ""))
            {
                ModelCell.ModelCreateCell(name, description, login, password, path);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ControlerDeleteCell(string pathToBlock, int index)
        {
            if(File.Exists(pathToBlock))
            {
                ModelCell.ModelDeleteCell(pathToBlock, index);
            }
        }

        public static void ControllerChangeCell(string pathToBlock, int index, string name, string description, string login, string password)
        {
            if(File.Exists(pathToBlock))
            {
                ModelCell.ModelChangeCell(pathToBlock, index, name, description, login, password);
            }
        }
    }
}
