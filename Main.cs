
using Hidepass.Logic;
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC;
using Hidepass.Logic.MVC.Block;
using Hidepass.Logic.MVC.Cell;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass
{
    public partial class Main : Form
    {
        public static readonly string GlobalPathToDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Hidepass";
        public static readonly string GlobalPathToFileMetadata = GlobalPathToDir + @"\blockmetadata.json";

        public Main()
        {
            Initialization.ComponentsCheck(GlobalPathToDir, GlobalPathToFileMetadata);
            InitializeComponent();
            if(File.ReadAllText(GlobalPathToFileMetadata) != "")
            {
                ViewPassword.DisplayBlocks(listBlocks, GlobalPathToFileMetadata);
            }
        }

        private void testCreateBlockButton_Click(object sender, EventArgs e)
        {
            string pathToFile = @$"{GlobalPathToDir}\{testNameInput.Text}.json";

            ControllerBlock.ControlCreateBlock(testNameInput.Text, testDesInput.Text, pathToFile);

            ViewPassword.DisplayBlocks(listBlocks, GlobalPathToFileMetadata);
        }

        private void testCreateCellButton_Click(object sender, EventArgs e)
        {
            int selectIndex = listBlocks.SelectedIndex;
            string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GlobalPathToFileMetadata)).Blocks[selectIndex].PathToFile;

            ControllerCell.ControlCreateCell(inputName.Text, inputDesc.Text, inputLogin.Text, inputPassword.Text, path);

            ViewPassword.DisplayCells(listCells, path);
        }
    }
}
