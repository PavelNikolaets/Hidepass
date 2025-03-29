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
            SuspendLayout();
            // 
            // InputName
            // 
            InputName.Location = new Point(12, 12);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(222, 23);
            InputName.TabIndex = 2;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(12, 41);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.Size = new Size(222, 125);
            InputDescription.TabIndex = 3;
            // 
            // InputLogin
            // 
            InputLogin.Location = new Point(12, 172);
            InputLogin.Name = "InputLogin";
            InputLogin.PlaceholderText = "Логин";
            InputLogin.Size = new Size(222, 23);
            InputLogin.TabIndex = 4;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(12, 201);
            InputPassword.Name = "InputPassword";
            InputPassword.PlaceholderText = "Пароль";
            InputPassword.Size = new Size(222, 23);
            InputPassword.TabIndex = 5;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 230);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(222, 43);
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
            ClientSize = new Size(246, 281);
            Controls.Add(ButtonCreate);
            Controls.Add(InputPassword);
            Controls.Add(InputLogin);
            Controls.Add(InputDescription);
            Controls.Add(InputName);
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