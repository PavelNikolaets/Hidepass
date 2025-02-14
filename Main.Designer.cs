namespace Hidepass
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testCreateBlockButton = new Button();
            testCreateCellButton = new Button();
            testNameInput = new TextBox();
            testDesInput = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // testCreateBlockButton
            // 
            testCreateBlockButton.Location = new Point(12, 383);
            testCreateBlockButton.Name = "testCreateBlockButton";
            testCreateBlockButton.Size = new Size(233, 55);
            testCreateBlockButton.TabIndex = 0;
            testCreateBlockButton.Text = "Создать блок";
            testCreateBlockButton.UseVisualStyleBackColor = true;
            // 
            // testCreateCellButton
            // 
            testCreateCellButton.Location = new Point(555, 383);
            testCreateCellButton.Name = "testCreateCellButton";
            testCreateCellButton.Size = new Size(233, 55);
            testCreateCellButton.TabIndex = 1;
            testCreateCellButton.Text = "Создать ячейку";
            testCreateCellButton.UseVisualStyleBackColor = true;
            // 
            // testNameInput
            // 
            testNameInput.Location = new Point(12, 279);
            testNameInput.Name = "testNameInput";
            testNameInput.PlaceholderText = "Название";
            testNameInput.Size = new Size(233, 23);
            testNameInput.TabIndex = 2;
            // 
            // testDesInput
            // 
            testDesInput.Location = new Point(12, 308);
            testDesInput.Multiline = true;
            testDesInput.Name = "testDesInput";
            testDesInput.PlaceholderText = "Описание";
            testDesInput.Size = new Size(233, 69);
            testDesInput.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(555, 325);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Логин";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(555, 354);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Пароль";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(testDesInput);
            Controls.Add(testNameInput);
            Controls.Add(testCreateCellButton);
            Controls.Add(testCreateBlockButton);
            Name = "Main";
            Text = "Passhide";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button testCreateBlockButton;
        private Button testCreateCellButton;
        private TextBox testNameInput;
        private TextBox testDesInput;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
