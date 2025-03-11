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
            ListBlocks = new ListBox();
            ListCells = new ListBox();
            ButtonCreateBlock = new Button();
            ButtonChangeBlock = new Button();
            ButtonDeleteBlock = new Button();
            ButtonCreateCell = new Button();
            ButtonChangeCell = new Button();
            ButtonDeleteCell = new Button();
            BlockDescription = new Label();
            SuspendLayout();
            // 
            // ListBlocks
            // 
            ListBlocks.FormattingEnabled = true;
            ListBlocks.HorizontalScrollbar = true;
            ListBlocks.ItemHeight = 15;
            ListBlocks.Location = new Point(12, 12);
            ListBlocks.Name = "ListBlocks";
            ListBlocks.Size = new Size(273, 289);
            ListBlocks.TabIndex = 0;
            ListBlocks.SelectedIndexChanged += ListBlocks_SelectedIndexChanged;
            // 
            // ListCells
            // 
            ListCells.FormattingEnabled = true;
            ListCells.HorizontalScrollbar = true;
            ListCells.ItemHeight = 15;
            ListCells.Location = new Point(291, 12);
            ListCells.Name = "ListCells";
            ListCells.Size = new Size(497, 379);
            ListCells.TabIndex = 1;
            ListCells.DoubleClick += ListCells_DoubleClick;
            // 
            // ButtonCreateBlock
            // 
            ButtonCreateBlock.Location = new Point(12, 397);
            ButtonCreateBlock.Name = "ButtonCreateBlock";
            ButtonCreateBlock.Size = new Size(87, 41);
            ButtonCreateBlock.TabIndex = 2;
            ButtonCreateBlock.Text = "Создать блок";
            ButtonCreateBlock.UseVisualStyleBackColor = true;
            ButtonCreateBlock.Click += ButtonCreateBlock_Click;
            // 
            // ButtonChangeBlock
            // 
            ButtonChangeBlock.Location = new Point(105, 397);
            ButtonChangeBlock.Name = "ButtonChangeBlock";
            ButtonChangeBlock.Size = new Size(87, 41);
            ButtonChangeBlock.TabIndex = 3;
            ButtonChangeBlock.Text = "Изменить блок";
            ButtonChangeBlock.UseVisualStyleBackColor = true;
            ButtonChangeBlock.Click += ButtonChangeBlock_Click;
            // 
            // ButtonDeleteBlock
            // 
            ButtonDeleteBlock.Location = new Point(198, 397);
            ButtonDeleteBlock.Name = "ButtonDeleteBlock";
            ButtonDeleteBlock.Size = new Size(87, 41);
            ButtonDeleteBlock.TabIndex = 4;
            ButtonDeleteBlock.Text = "Удалить блок";
            ButtonDeleteBlock.UseVisualStyleBackColor = true;
            ButtonDeleteBlock.Click += ButtonDeleteBlock_Click;
            // 
            // ButtonCreateCell
            // 
            ButtonCreateCell.Location = new Point(515, 397);
            ButtonCreateCell.Name = "ButtonCreateCell";
            ButtonCreateCell.Size = new Size(87, 41);
            ButtonCreateCell.TabIndex = 5;
            ButtonCreateCell.Text = "Создать ячейку";
            ButtonCreateCell.UseVisualStyleBackColor = true;
            ButtonCreateCell.Click += ButtonCreateCell_Click;
            // 
            // ButtonChangeCell
            // 
            ButtonChangeCell.Location = new Point(608, 397);
            ButtonChangeCell.Name = "ButtonChangeCell";
            ButtonChangeCell.Size = new Size(87, 41);
            ButtonChangeCell.TabIndex = 6;
            ButtonChangeCell.Text = "Изменить ячейку";
            ButtonChangeCell.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteCell
            // 
            ButtonDeleteCell.Location = new Point(701, 397);
            ButtonDeleteCell.Name = "ButtonDeleteCell";
            ButtonDeleteCell.Size = new Size(87, 41);
            ButtonDeleteCell.TabIndex = 7;
            ButtonDeleteCell.Text = "Удалить ячейку";
            ButtonDeleteCell.UseVisualStyleBackColor = true;
            ButtonDeleteCell.Click += ButtonDeleteCell_Click;
            // 
            // BlockDescription
            // 
            BlockDescription.BorderStyle = BorderStyle.Fixed3D;
            BlockDescription.Location = new Point(12, 304);
            BlockDescription.Name = "BlockDescription";
            BlockDescription.Size = new Size(273, 87);
            BlockDescription.TabIndex = 8;
            BlockDescription.Text = "Описание:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BlockDescription);
            Controls.Add(ButtonDeleteCell);
            Controls.Add(ButtonChangeCell);
            Controls.Add(ButtonCreateCell);
            Controls.Add(ButtonDeleteBlock);
            Controls.Add(ButtonChangeBlock);
            Controls.Add(ButtonCreateBlock);
            Controls.Add(ListCells);
            Controls.Add(ListBlocks);
            Name = "Main";
            Text = "Passhide";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBlocks;
        private ListBox ListCells;
        private Button ButtonCreateBlock;
        private Button ButtonChangeBlock;
        private Button ButtonDeleteBlock;
        private Button ButtonCreateCell;
        private Button ButtonChangeCell;
        private Button ButtonDeleteCell;
        private Label BlockDescription;
    }
}
