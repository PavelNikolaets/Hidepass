﻿namespace Hidepass.Forms.Block
{
    partial class FCreateBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCreateBlock));
            InputName = new TextBox();
            InputDescription = new TextBox();
            ButtonCreate = new Button();
            InputMasterKey = new TextBox();
            SuspendLayout();
            // 
            // InputName
            // 
            InputName.Location = new Point(12, 12);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(303, 23);
            InputName.TabIndex = 1;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(12, 41);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.ScrollBars = ScrollBars.Vertical;
            InputDescription.Size = new Size(303, 174);
            InputDescription.TabIndex = 2;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 250);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(303, 43);
            ButtonCreate.TabIndex = 3;
            ButtonCreate.Text = "Создать";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // InputMasterKey
            // 
            InputMasterKey.Location = new Point(12, 221);
            InputMasterKey.Name = "InputMasterKey";
            InputMasterKey.PlaceholderText = "Мастер пароль";
            InputMasterKey.Size = new Size(303, 23);
            InputMasterKey.TabIndex = 4;
            // 
            // FCreateBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 311);
            Controls.Add(InputName);
            Controls.Add(InputDescription);
            Controls.Add(InputMasterKey);
            Controls.Add(ButtonCreate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimizeBox = false;
            MinimumSize = new Size(350, 350);
            Name = "FCreateBlock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание блока";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputName;
        private TextBox InputDescription;
        private Button ButtonCreate;
        private TextBox InputMasterKey;
    }
}