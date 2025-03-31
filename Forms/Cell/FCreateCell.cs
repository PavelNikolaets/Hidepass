
using Hidepass.Logic.MVC.Cell;

namespace Hidepass.Forms.Cell
{
    public partial class FCreateCell : Form
    {
        public string PathToBlock { get; set; }

        public FCreateCell(string pathToBlock)
        {
            InitializeComponent();

            this.Font = new("Arial", 9);

            PathToBlock = pathToBlock;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ControllerCell.ControllerCreateCell(InputName.Text, InputDescription.Text, InputLogin.Text, InputPassword.Text, PathToBlock, DateTime.Now.ToString("g"), Main.CurrentMasterKey);
            Close();
        }
    }
}
