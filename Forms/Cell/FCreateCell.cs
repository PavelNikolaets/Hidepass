
using Hidepass.Logic.MVC.Cell;

namespace Hidepass.Forms.Cell
{
    public partial class FCreateCell : Form
    {
        public string PathToBlock { get; set; }

        public FCreateCell(string pathToBlock)
        {
            InitializeComponent();
            PathToBlock = pathToBlock;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ControllerCell.ControllerCreateCell(InputName.Text, InputDescription.Text, InputLogin.Text, InputPassword.Text, PathToBlock);
            Close();
        }
    }
}
