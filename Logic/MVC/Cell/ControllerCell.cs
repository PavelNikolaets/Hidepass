
namespace Hidepass.Logic.MVC.Cell
{
    internal class ControllerCell
    {
        public static void ControlCreateCell(string name, string description, string login, string password, string path)
        {
            string[] paramAll = [name, description, login, password, path];
            if (paramAll.All(p => p != ""))
            {
                ModelCell.ModelCreateCell(name, description, login, password, path);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
