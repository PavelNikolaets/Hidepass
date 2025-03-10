
using Hidepass.Logic.FileOperations;
using Hidepass.Logic.MVC.Block;
using Hidepass.ObjectTemplates;

namespace Hidepass.Forms.Block
{
    public partial class ChangeBlock : Form
    {
        public int Index {  get; set; }


        public ChangeBlock(int index)
        {
            InitializeComponent();
            Index = index;

            RootBlock obj = JsonService.ToObject<RootBlock>(File.ReadAllText(Main.GPathToFileMetadata));
            InputName.Text = obj.Blocks[index].Name;
            InputDescription.Text = obj.Blocks[index].Description;

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            ControllerBlock.ControllerChangeBlock(Index, InputName.Text, InputDescription.Text);
            Close();
        }
    }
}
