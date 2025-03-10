
namespace Hidepass.Logic.MVC.Cell
{
    internal class ControllerCell
    {
        public static void ControllerCreateCell(string name, string description, string login, string password, string pathToBlock)
        {
            string[] paramAll = [name, login, password, pathToBlock];
            if (paramAll.All(p => p != ""))
            {
                if (File.Exists(pathToBlock) == false)
                {
                    ModelCell.ModelCreateCell(name, description, login, password, pathToBlock);
                }
                else
                {
                    MessageBox.Show("Такой блок уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
