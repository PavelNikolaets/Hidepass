﻿namespace Hidepass.Forms.Cell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChangeCell));
            button1 = new Button();
            InputPassword = new TextBox();
            InputLogin = new TextBox();
            InputDescription = new TextBox();
            InputName = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 250);
            button1.Name = "button1";
            button1.Size = new Size(307, 43);
            button1.TabIndex = 11;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InputPassword
            // 
            InputPassword.Location = new Point(3, 221);
            InputPassword.Name = "InputPassword";
            InputPassword.PlaceholderText = "Пароль";
            InputPassword.Size = new Size(307, 23);
            InputPassword.TabIndex = 10;
            // 
            // InputLogin
            // 
            InputLogin.Location = new Point(3, 192);
            InputLogin.Name = "InputLogin";
            InputLogin.PlaceholderText = "Логин";
            InputLogin.Size = new Size(307, 23);
            InputLogin.TabIndex = 9;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(3, 32);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.Size = new Size(307, 154);
            InputDescription.TabIndex = 8;
            // 
            // InputName
            // 
            InputName.Location = new Point(3, 3);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(307, 23);
            InputName.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(InputName);
            flowLayoutPanel1.Controls.Add(InputDescription);
            flowLayoutPanel1.Controls.Add(InputLogin);
            flowLayoutPanel1.Controls.Add(InputPassword);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(313, 296);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // FChangeCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 311);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimizeBox = false;
            MinimumSize = new Size(350, 350);
            Name = "FChangeCell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение ячейки";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox InputPassword;
        private TextBox InputLogin;
        private TextBox InputDescription;
        private TextBox InputName;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}