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
            inputLogin = new TextBox();
            inputPassword = new TextBox();
            inputDesc = new TextBox();
            inputName = new TextBox();
            listCells = new ListBox();
            listBlocks = new ListBox();
            buttonBlockDelete = new Button();
            buttonBlockChange = new Button();
            buttonDeleteCell = new Button();
            buttonChangeCell = new Button();
            SuspendLayout();
            // 
            // testCreateBlockButton
            // 
            testCreateBlockButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            testCreateBlockButton.Cursor = Cursors.Hand;
            testCreateBlockButton.Location = new Point(12, 383);
            testCreateBlockButton.Name = "testCreateBlockButton";
            testCreateBlockButton.Size = new Size(233, 55);
            testCreateBlockButton.TabIndex = 0;
            testCreateBlockButton.Text = "Создать блок";
            testCreateBlockButton.UseVisualStyleBackColor = true;
            testCreateBlockButton.Click += testCreateBlockButton_Click;
            // 
            // testCreateCellButton
            // 
            testCreateCellButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            testCreateCellButton.Cursor = Cursors.Hand;
            testCreateCellButton.Location = new Point(555, 383);
            testCreateCellButton.Name = "testCreateCellButton";
            testCreateCellButton.Size = new Size(233, 55);
            testCreateCellButton.TabIndex = 1;
            testCreateCellButton.Text = "Создать ячейку";
            testCreateCellButton.UseVisualStyleBackColor = true;
            testCreateCellButton.Click += testCreateCellButton_Click;
            // 
            // testNameInput
            // 
            testNameInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            testNameInput.Location = new Point(12, 279);
            testNameInput.Name = "testNameInput";
            testNameInput.PlaceholderText = "Название";
            testNameInput.Size = new Size(233, 23);
            testNameInput.TabIndex = 2;
            // 
            // testDesInput
            // 
            testDesInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            testDesInput.Location = new Point(12, 308);
            testDesInput.Multiline = true;
            testDesInput.Name = "testDesInput";
            testDesInput.PlaceholderText = "Описание";
            testDesInput.Size = new Size(233, 69);
            testDesInput.TabIndex = 3;
            // 
            // inputLogin
            // 
            inputLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inputLogin.Location = new Point(555, 325);
            inputLogin.Name = "inputLogin";
            inputLogin.PlaceholderText = "Логин";
            inputLogin.Size = new Size(233, 23);
            inputLogin.TabIndex = 4;
            // 
            // inputPassword
            // 
            inputPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inputPassword.Location = new Point(555, 354);
            inputPassword.Name = "inputPassword";
            inputPassword.PlaceholderText = "Пароль";
            inputPassword.Size = new Size(233, 23);
            inputPassword.TabIndex = 5;
            // 
            // inputDesc
            // 
            inputDesc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inputDesc.Location = new Point(555, 250);
            inputDesc.Multiline = true;
            inputDesc.Name = "inputDesc";
            inputDesc.PlaceholderText = "Описание";
            inputDesc.Size = new Size(233, 69);
            inputDesc.TabIndex = 6;
            // 
            // inputName
            // 
            inputName.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            inputName.Location = new Point(555, 221);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Название";
            inputName.Size = new Size(233, 23);
            inputName.TabIndex = 7;
            // 
            // listCells
            // 
            listCells.ItemHeight = 15;
            listCells.Location = new Point(251, 222);
            listCells.Name = "listCells";
            listCells.Size = new Size(298, 214);
            listCells.TabIndex = 9;
            // 
            // listBlocks
            // 
            listBlocks.FormattingEnabled = true;
            listBlocks.ItemHeight = 15;
            listBlocks.Location = new Point(251, 12);
            listBlocks.Name = "listBlocks";
            listBlocks.Size = new Size(298, 199);
            listBlocks.TabIndex = 10;
            // 
            // buttonBlockDelete
            // 
            buttonBlockDelete.Location = new Point(12, 12);
            buttonBlockDelete.Name = "buttonBlockDelete";
            buttonBlockDelete.Size = new Size(233, 53);
            buttonBlockDelete.TabIndex = 11;
            buttonBlockDelete.Text = "Удалить блок";
            buttonBlockDelete.UseVisualStyleBackColor = true;
            // 
            // buttonBlockChange
            // 
            buttonBlockChange.Location = new Point(12, 71);
            buttonBlockChange.Name = "buttonBlockChange";
            buttonBlockChange.Size = new Size(233, 53);
            buttonBlockChange.TabIndex = 12;
            buttonBlockChange.Text = "Изменить блок";
            buttonBlockChange.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCell
            // 
            buttonDeleteCell.Location = new Point(12, 158);
            buttonDeleteCell.Name = "buttonDeleteCell";
            buttonDeleteCell.Size = new Size(233, 53);
            buttonDeleteCell.TabIndex = 13;
            buttonDeleteCell.Text = "Удалить ячейку";
            buttonDeleteCell.UseVisualStyleBackColor = true;
            // 
            // buttonChangeCell
            // 
            buttonChangeCell.Location = new Point(12, 220);
            buttonChangeCell.Name = "buttonChangeCell";
            buttonChangeCell.Size = new Size(233, 53);
            buttonChangeCell.TabIndex = 14;
            buttonChangeCell.Text = "Изменить ячейку";
            buttonChangeCell.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonChangeCell);
            Controls.Add(buttonDeleteCell);
            Controls.Add(buttonBlockChange);
            Controls.Add(buttonBlockDelete);
            Controls.Add(listBlocks);
            Controls.Add(listCells);
            Controls.Add(inputName);
            Controls.Add(inputDesc);
            Controls.Add(inputPassword);
            Controls.Add(inputLogin);
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
        private TextBox inputLogin;
        private TextBox inputPassword;
        private TextBox inputDesc;
        private TextBox inputName;
        private ListBox listCells;
        private ListBox listBlocks;
        private Button buttonBlockDelete;
        private Button buttonBlockChange;
        private Button buttonDeleteCell;
        private Button buttonChangeCell;
    }
}
