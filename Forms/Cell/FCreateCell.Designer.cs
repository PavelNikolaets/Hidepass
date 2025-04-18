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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCreateCell));
            InputName = new TextBox();
            InputDescription = new TextBox();
            InputLogin = new TextBox();
            InputPassword = new TextBox();
            ButtonCreate = new Button();
            SuspendLayout();
            // 
            // InputName
            // 
            InputName.Location = new Point(12, 12);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(307, 23);
            InputName.TabIndex = 2;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(12, 41);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.Size = new Size(307, 145);
            InputDescription.TabIndex = 3;
            // 
            // InputLogin
            // 
            InputLogin.Location = new Point(12, 192);
            InputLogin.Name = "InputLogin";
            InputLogin.PlaceholderText = "Логин";
            InputLogin.Size = new Size(307, 23);
            InputLogin.TabIndex = 4;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(12, 221);
            InputPassword.Name = "InputPassword";
            InputPassword.PlaceholderText = "Пароль";
            InputPassword.Size = new Size(307, 23);
            InputPassword.TabIndex = 5;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 252);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(307, 43);
            ButtonCreate.TabIndex = 6;
            ButtonCreate.Text = "Создать";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // FCreateCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 311);
            Controls.Add(InputName);
            Controls.Add(ButtonCreate);
            Controls.Add(InputDescription);
            Controls.Add(InputLogin);
            Controls.Add(InputPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimizeBox = false;
            MinimumSize = new Size(350, 350);
            Name = "FCreateCell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание ячейки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputName;
        private TextBox InputDescription;
        private TextBox InputLogin;
        private TextBox InputPassword;
        private Button ButtonCreate;
    }
}