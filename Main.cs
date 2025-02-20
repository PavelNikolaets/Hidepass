
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC.Block;
using Hidepass.Logic.MVC.Cell;
using Hidepass.ObjectTemplates;

namespace Hidepass
{
    public partial class Main : Form
    {
        public static readonly string GlobalPathToDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Hidepass";
        public static readonly string GlobalPathToFile = GlobalPathToDir + @"\blocklist.json";

        public Main()
        {
            FileAndDirService.CreateDir(@$"{GlobalPathToDir}");
            InitializeComponent();
        }

        private void testCreateBlockButton_Click(object sender, EventArgs e)
        {
            string name = testNameInput.Text;
            string description = testNameInput.Text;

            ControllerBlock.ControlCreateBlock(name, description);
        }

        private void testCreateCellButton_Click(object sender, EventArgs e)
        {
            string name = testNameInput.Text;
            string description = testDesInput.Text;
            string login = testDesInput.Text;
            string password = testDesInput.Text;
            string path = "C:\\Users\\pavel\\Documents\\Hidepass\\blocklist.json";
            ListBlocks test = JsonService.ToObject<ListBlocks>(File.ReadAllText(GlobalPathToFile));

            ControllerCell.ControlCreateCell(name, description, login, password, path);
        }
    }
}
