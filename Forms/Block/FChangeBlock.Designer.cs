namespace Hidepass.Forms.Block
{
    partial class FChangeBlock
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
            ButtonChange = new Button();
            SuspendLayout();
            // 
            // InputName
            // 
            InputName.Location = new Point(12, 12);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Нзвание";
            InputName.Size = new Size(222, 23);
            InputName.TabIndex = 0;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(12, 41);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.ScrollBars = ScrollBars.Vertical;
            InputDescription.Size = new Size(222, 125);
            InputDescription.TabIndex = 1;
            // 
            // ButtonChange
            // 
            ButtonChange.Location = new Point(12, 172);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(222, 43);
            ButtonChange.TabIndex = 2;
            ButtonChange.Text = "Изменить";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // FChangeBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(246, 223);
            Controls.Add(ButtonChange);
            Controls.Add(InputDescription);
            Controls.Add(InputName);
            Name = "FChangeBlock";
            Text = "Изменение блока";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputName;
        private TextBox InputDescription;
        private Button ButtonChange;
    }
}