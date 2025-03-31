
using Hidepass.ObjectTemplates;
using Hidepass.Logic;

namespace Hidepass.Forms.Cell
{
    public partial class FViewCell : Form
    {
        public CellObject Obj { get; set; }

        public FViewCell(CellObject obj)
        {
            InitializeComponent();

            this.Font = new("Arial", 9);

            Obj = obj;

            LabelName.Text = "Название: " + obj.Name;
            LabelDescription.Text = "Описание: " + obj.Description;
            LabelLogin.Text = "Логин: " + obj.Login;
            LabelPassword.Text = "Пароль: " + obj.Password;
            LabelTimeCreate.Text = "Дата создания: " + obj.DateCreate;
            LabelTimeUpdate.Text = obj.DateUpdate == "" ? "Дата изменения: изменений не было" : "Дата изменения: " + obj.DateUpdate;

            InitPasswordCheckBar();

            this.MaximumSize = this.Size;
        }

        private void InitPasswordCheckBar()
        {
            int passwordStrength = PasswordStrengthChecker.Evaluate(Obj.Password);
            BarPasswordСomplexity.Value = passwordStrength;
            LblPasswordStrength.Text = $"Сила пароля: {passwordStrength}/5";
        }

        private void ButtonCopyLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Obj.Login);
        }

        private void ButtonCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Obj.Password);
        }
    }
}
