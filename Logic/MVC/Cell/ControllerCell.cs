
namespace Hidepass.Logic.MVC.Cell
{
    internal class ControllerCell
    {
        public static void ControllerCreateCell(string name, string description, string login, string password, string pathToBlock, string dateCreate, string key)
        {
            string[] paramAll = [name, login, password, pathToBlock];
            if (paramAll.All(p => p != ""))
            {
                ModelCell.ModelCreateCell(name, description, login, password, key, dateCreate, pathToBlock);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ControlerDeleteCell(string pathToBlock, int index, string key)
        {
            if(File.Exists(pathToBlock))
            {
                ModelCell.ModelDeleteCell(pathToBlock, index, key);
            }
        }

        public static void ControllerChangeCell(string pathToBlock, int index, string name, string description, string login, string password, string key)
        {
            if(File.Exists(pathToBlock))
            {
                ModelCell.ModelChangeCell(pathToBlock, index, name, description, login, password, key);
            }
        }
    }
}
