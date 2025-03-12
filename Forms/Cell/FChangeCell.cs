
using Hidepass.Logic.MVC.Cell;
using Hidepass.ObjectTemplates;

namespace Hidepass.Forms.Cell
{
    public partial class FChangeCell : Form
    {
        public CellObject Obj { get; set; }
        public string Path { get; set; }
        public int Index { get; set; }
        public FChangeCell(CellObject obj, string path, int index)
        {
            InitializeComponent();
            Obj = obj;
            Path = path;
            Index = index;

            InputName.Text = Obj.Name;
            InputDescription.Text = Obj.Description;
            InputLogin.Text = Obj.Login;
            InputPassword.Text = Obj.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControllerCell.ControllerChangeCell(Path, Index, InputName.Text, InputDescription.Text, InputLogin.Text, InputPassword.Text);
            Close();
        }
    }
}
