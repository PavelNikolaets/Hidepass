namespace Hidepass.Forms.Cell
{
    partial class FViewCell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelName = new Label();
            LabelDescription = new Label();
            LabelLogin = new Label();
            LabelPassword = new Label();
            LabelTimeCreate = new Label();
            ButtonCopyLogin = new Button();
            ButtonCopyPassword = new Button();
            LabelTimeUpdate = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BorderStyle = BorderStyle.Fixed3D;
            LabelName.Location = new Point(5, 5);
            LabelName.Margin = new Padding(5);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(117, 17);
            LabelName.TabIndex = 0;
            LabelName.Text = "Название: название";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.BorderStyle = BorderStyle.Fixed3D;
            LabelDescription.Location = new Point(5, 32);
            LabelDescription.Margin = new Padding(5);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(123, 17);
            LabelDescription.TabIndex = 1;
            LabelDescription.Text = "Описание: описание";
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.BorderStyle = BorderStyle.Fixed3D;
            LabelLogin.Location = new Point(5, 5);
            LabelLogin.Margin = new Padding(5);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(82, 17);
            LabelLogin.TabIndex = 2;
            LabelLogin.Text = "Логин: логин";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.BorderStyle = BorderStyle.Fixed3D;
            LabelPassword.Location = new Point(5, 5);
            LabelPassword.Margin = new Padding(5);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(97, 17);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Пароль: пароль";
            // 
            // LabelTimeCreate
            // 
            LabelTimeCreate.AutoSize = true;
            LabelTimeCreate.BorderStyle = BorderStyle.Fixed3D;
            LabelTimeCreate.Location = new Point(5, 125);
            LabelTimeCreate.Margin = new Padding(5);
            LabelTimeCreate.Name = "LabelTimeCreate";
            LabelTimeCreate.Size = new Size(177, 17);
            LabelTimeCreate.TabIndex = 4;
            LabelTimeCreate.Text = "Дата создания: 00.00.0000 00:00";
            // 
            // ButtonCopyLogin
            // 
            ButtonCopyLogin.FlatStyle = FlatStyle.Popup;
            ButtonCopyLogin.Image = Properties.Resources.icons8_copy_17;
            ButtonCopyLogin.Location = new Point(95, 3);
            ButtonCopyLogin.Name = "ButtonCopyLogin";
            ButtonCopyLogin.Size = new Size(18, 18);
            ButtonCopyLogin.TabIndex = 5;
            ButtonCopyLogin.UseVisualStyleBackColor = true;
            ButtonCopyLogin.Click += ButtonCopyLogin_Click;
            // 
            // ButtonCopyPassword
            // 
            ButtonCopyPassword.FlatStyle = FlatStyle.Popup;
            ButtonCopyPassword.Image = Properties.Resources.icons8_copy_17;
            ButtonCopyPassword.Location = new Point(110, 3);
            ButtonCopyPassword.Name = "ButtonCopyPassword";
            ButtonCopyPassword.Size = new Size(18, 18);
            ButtonCopyPassword.TabIndex = 6;
            ButtonCopyPassword.UseVisualStyleBackColor = true;
            ButtonCopyPassword.Click += ButtonCopyPassword_Click;
            // 
            // LabelTimeUpdate
            // 
            LabelTimeUpdate.AutoSize = true;
            LabelTimeUpdate.BorderStyle = BorderStyle.Fixed3D;
            LabelTimeUpdate.Location = new Point(5, 152);
            LabelTimeUpdate.Margin = new Padding(5);
            LabelTimeUpdate.Name = "LabelTimeUpdate";
            LabelTimeUpdate.Size = new Size(187, 17);
            LabelTimeUpdate.TabIndex = 7;
            LabelTimeUpdate.Text = "Дата изменения: 00.00.0000 00:00";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(LabelLogin);
            flowLayoutPanel1.Controls.Add(ButtonCopyLogin);
            flowLayoutPanel1.Location = new Point(3, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(116, 27);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(LabelPassword);
            flowLayoutPanel2.Controls.Add(ButtonCopyPassword);
            flowLayoutPanel2.Location = new Point(3, 90);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(131, 27);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(LabelName);
            flowLayoutPanel3.Controls.Add(LabelDescription);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel3.Controls.Add(LabelTimeCreate);
            flowLayoutPanel3.Controls.Add(LabelTimeUpdate);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(12, 12);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(202, 190);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // FViewCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(226, 214);
            Controls.Add(flowLayoutPanel3);
            Name = "FViewCell";
            Text = "Просмотр ячейки";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelName;
        private Label LabelDescription;
        private Label LabelLogin;
        private Label LabelPassword;
        private Label LabelTimeCreate;
        private Button ButtonCopyLogin;
        private Button ButtonCopyPassword;
        private Label LabelTimeUpdate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}