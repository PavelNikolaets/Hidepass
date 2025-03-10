
using Hidepass.Logic.MVC.Block;

namespace Hidepass.Forms.Block
{
    public partial class CreateBlock : Form
    {
        public CreateBlock()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ControllerBlock.ControllerCreateBlock(InputName.Text, InputDescription.Text, @$"{Main.GPathToDir}\{InputName.Text}.json");
            Close();
        }
    }
}
