
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC.Block;
using Hidepass.Logic.MVC.Cell;
using Hidepass.ObjectTemplates;
using Hidepass.Logic;

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
        }

        private void testCreateBlockButton_Click(object sender, EventArgs e)
        {
            ControllerBlock.ControlCreateBlock(testNameInput.Text, testDesInput.Text, @$"{GlobalPathToDir}\{testNameInput.Text}.json");
        }

        private void testCreateCellButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
