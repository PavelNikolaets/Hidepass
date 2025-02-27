
using Hidepass.Logic.FileOperations;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass.Logic.MVC.Block
{
    internal class ControllerBlock
    {
        public static void ControlCreateBlock(string name, string description, string pathToBlock)
        {
            if (name != "" && description != "" && pathToBlock != "")
            {
                ModelBlock.ModelCreateBlock(name, description, pathToBlock);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
