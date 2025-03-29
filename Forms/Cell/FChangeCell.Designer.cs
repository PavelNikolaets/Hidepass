namespace Hidepass.Forms.Cell
{
    partial class FChangeCell
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
            button1 = new Button();
            InputPassword = new TextBox();
            InputLogin = new TextBox();
            InputDescription = new TextBox();
            InputName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 230);
            button1.Name = "button1";
            button1.Size = new Size(222, 43);
            button1.TabIndex = 11;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(12, 201);
            InputPassword.Name = "InputPassword";
            InputPassword.PlaceholderText = "Пароль";
            InputPassword.Size = new Size(222, 23);
            InputPassword.TabIndex = 10;
            // 
            // InputLogin
            // 
            InputLogin.Location = new Point(12, 172);
            InputLogin.Name = "InputLogin";
            InputLogin.PlaceholderText = "Логин";
            InputLogin.Size = new Size(222, 23);
            InputLogin.TabIndex = 9;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(12, 41);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.Size = new Size(222, 125);
            InputDescription.TabIndex = 8;
            // 
            // InputName
            // 
            InputName.Location = new Point(12, 12);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(222, 23);
            InputName.TabIndex = 7;
            // 
            // FChangeCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(246, 281);
            Controls.Add(button1);
            Controls.Add(InputPassword);
            Controls.Add(InputLogin);
            Controls.Add(InputDescription);
            Controls.Add(InputName);
            Name = "FChangeCell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение ячейки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox InputPassword;
        private TextBox InputLogin;
        private TextBox InputDescription;
        private TextBox InputName;
    }
}