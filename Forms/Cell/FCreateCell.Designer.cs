namespace Hidepass.Forms.Cell
{
    partial class FCreateCell
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
            InputName = new TextBox();
            InputDescription = new TextBox();
            InputLogin = new TextBox();
            InputPassword = new TextBox();
            ButtonCreate = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // InputName
            // 
            InputName.Dock = DockStyle.Fill;
            InputName.Location = new Point(3, 3);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(307, 23);
            InputName.TabIndex = 2;
            // 
            // InputDescription
            // 
            InputDescription.Dock = DockStyle.Fill;
            InputDescription.Location = new Point(3, 32);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.Size = new Size(307, 145);
            InputDescription.TabIndex = 3;
            // 
            // InputLogin
            // 
            InputLogin.Dock = DockStyle.Fill;
            InputLogin.Location = new Point(3, 183);
            InputLogin.Name = "InputLogin";
            InputLogin.PlaceholderText = "Логин";
            InputLogin.Size = new Size(307, 23);
            InputLogin.TabIndex = 4;
            // 
            // InputPassword
            // 
            InputPassword.Dock = DockStyle.Fill;
            InputPassword.Location = new Point(3, 212);
            InputPassword.Name = "InputPassword";
            InputPassword.PlaceholderText = "Пароль";
            InputPassword.Size = new Size(307, 23);
            InputPassword.TabIndex = 5;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(3, 241);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(307, 43);
            ButtonCreate.TabIndex = 6;
            ButtonCreate.Text = "Создать";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(InputName);
            flowLayoutPanel1.Controls.Add(InputDescription);
            flowLayoutPanel1.Controls.Add(InputLogin);
            flowLayoutPanel1.Controls.Add(InputPassword);
            flowLayoutPanel1.Controls.Add(ButtonCreate);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(313, 287);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // FCreateCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 311);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimizeBox = false;
            MinimumSize = new Size(350, 350);
            Name = "FCreateCell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание ячейки";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputName;
        private TextBox InputDescription;
        private TextBox InputLogin;
        private TextBox InputPassword;
        private Button ButtonCreate;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}