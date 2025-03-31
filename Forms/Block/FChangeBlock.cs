
using Hidepass.Logic.MVC.Block;
using Hidepass.ObjectTemplates;

namespace Hidepass.Forms.Block
{
    public partial class FChangeBlock : Form
    {
        public BlockObject Obj { get; set; }
        public int Index { get; set; }

        public FChangeBlock(BlockObject obj, int index)
        {
            InitializeComponent();

            this.Font = new("Arial", 9);

            Obj = obj;
            Index = index;

            InputName.Text = obj.Name;
            InputDescription.Text = obj.Description;

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            ControllerBlock.ControllerChangeBlock(Index, InputName.Text, InputDescription.Text, Main.CurrentMasterKey);
            Close();
        }
    }
}
