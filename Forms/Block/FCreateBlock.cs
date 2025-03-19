
using Hidepass.Logic.MVC.Block;

namespace Hidepass.Forms.Block
{
    public partial class FCreateBlock : Form
    {
        public FCreateBlock()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ControllerBlock.ControllerCreateBlock(InputName.Text, InputDescription.Text, InputMasterKey.Text, @$"{Main.GPathToDir}\{InputName.Text}.json");
            Close();
        }
    }
}
