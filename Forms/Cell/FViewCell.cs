﻿
using Hidepass.ObjectTemplates;

namespace Hidepass.Forms.Cell
{
    public partial class FViewCell : Form
    {
        public CellObject Obj { get; set; }

        public FViewCell(CellObject obj)
        {
            InitializeComponent();
            Obj = obj;

            LabelName.Text = "Название: " + obj.Name;
            LabelDescription.Text = "Описание: " + obj.Description;
            LabelLogin.Text = "Логин: " + obj.Login;
            LabelPassword.Text = "Пароль: " + obj.Password;
            LabelTimeCreate.Text = "Дата создания: " + obj.DateCreate;
            LabelTimeUpdate.Text = "Дата изменения: " + obj.DateUpdate;
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
