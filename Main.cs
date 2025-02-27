
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
            if(File.ReadAllText(GlobalPathToFileMetadata) != "")
            {
                JsonService.ToObject<RootBlock>(File.ReadAllText(GlobalPathToFileMetadata)).Blocks.ForEach(block => comboBoxTest.Items.Add(block.Name));
            }
        }

        private void testCreateBlockButton_Click(object sender, EventArgs e)
        {
            ControllerBlock.ControlCreateBlock(testNameInput.Text, testDesInput.Text, @$"{GlobalPathToDir}\{testNameInput.Text}.json");
            comboBoxTest.Items.Clear();
            JsonService.ToObject<RootBlock>(File.ReadAllText(GlobalPathToFileMetadata)).Blocks.ForEach(block => comboBoxTest.Items.Add(block.Name));
        }

        private void testCreateCellButton_Click(object sender, EventArgs e)
        {
            int selectIndex = comboBoxTest.SelectedIndex;
            string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GlobalPathToFileMetadata)).Blocks[selectIndex].PathToFile;

            ControllerCell.ControlCreateCell(inputName.Text, inputDesc.Text, inputLogin.Text, inputPassword.Text, path);
        }
    }
}
