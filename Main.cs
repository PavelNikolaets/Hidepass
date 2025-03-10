
using Hidepass.Forms.Block;
using Hidepass.Logic;
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC;
using Hidepass.Logic.MVC.Block;
using Hidepass.ObjectTemplates;
using File = System.IO.File;

namespace Hidepass
{
    public partial class Main : Form
    {
        public static readonly string GPathToDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Hidepass";
        public static readonly string GPathToFileMetadata = GPathToDir + @"\blockmetadata.json";

        public static ListBox GListBlocks;
        public static ListBox GListCells;

        public Main()
        {
            Initialization.ComponentsCheck(GPathToDir, GPathToFileMetadata);
            InitializeComponent();

            GListBlocks = ListBlocks;
            GListCells = ListCells;

            Initialization.InitDisplay(GPathToFileMetadata);
        }

        private void ListBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewPassword.DisplayLabelDescription(BlockDescription, ListBlocks.SelectedIndex);
        }

        private void ButtonCreateBlock_Click(object sender, EventArgs e)
        {
            CreateBlock createBlock = new();

            createBlock.Show();
        }

        private void ButtonChangeBlock_Click(object sender, EventArgs e)
        {
            if (ListBlocks.SelectedIndex >= 0)
            {
                ChangeBlock changeBlock = new(ListBlocks.SelectedIndex);

                changeBlock.Show();
            }
        }

        private void ButtonDeleteBlock_Click(object sender, EventArgs e)
        {
            int index = ListBlocks.SelectedIndex;

            string path = JsonService.ToObject<RootBlock>(File.ReadAllText(GPathToFileMetadata)).Blocks[index].PathToFile;

            ControllerBlock.ControllerDeleteBlock(path, index);
            ViewPassword.DisplayLabelDescription(BlockDescription, -1);
        }
    }
}
