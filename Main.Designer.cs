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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            ListBlocks = new ListBox();
            ListCells = new ListBox();
            ButtonCreateBlock = new Button();
            ButtonChangeBlock = new Button();
            ButtonDeleteBlock = new Button();
            ButtonCreateCell = new Button();
            ButtonChangeCell = new Button();
            ButtonDeleteCell = new Button();
            BlockDescription = new Label();
            MenuTools = new ToolStrip();
            Files = new ToolStripDropDownButton();
            ImportToolStripMenuItem = new ToolStripMenuItem();
            ExportToolStripMenuItem = new ToolStripMenuItem();
            toolStripBtnAbout = new ToolStripButton();
            MenuTools.SuspendLayout();
            SuspendLayout();
            // 
            // ListBlocks
            // 
            ListBlocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListBlocks.FormattingEnabled = true;
            ListBlocks.HorizontalScrollbar = true;
            ListBlocks.ItemHeight = 15;
            ListBlocks.Location = new Point(12, 42);
            ListBlocks.Name = "ListBlocks";
            ListBlocks.Size = new Size(273, 259);
            ListBlocks.TabIndex = 0;
            ListBlocks.MouseClick += ListBlocks_MouseClick;
            ListBlocks.MouseDoubleClick += ListBlocks_MouseDoubleClick;
            // 
            // ListCells
            // 
            ListCells.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListCells.FormattingEnabled = true;
            ListCells.HorizontalScrollbar = true;
            ListCells.ItemHeight = 15;
            ListCells.Location = new Point(291, 42);
            ListCells.Name = "ListCells";
            ListCells.Size = new Size(497, 349);
            ListCells.TabIndex = 1;
            ListCells.MouseDoubleClick += ListCells_MouseDoubleClick;
            // 
            // ButtonCreateBlock
            // 
            ButtonCreateBlock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            ButtonChangeBlock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            ButtonDeleteBlock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            ButtonCreateCell.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            ButtonChangeCell.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonChangeCell.Location = new Point(608, 397);
            ButtonChangeCell.Name = "ButtonChangeCell";
            ButtonChangeCell.Size = new Size(87, 41);
            ButtonChangeCell.TabIndex = 6;
            ButtonChangeCell.Text = "Изменить ячейку";
            ButtonChangeCell.UseVisualStyleBackColor = true;
            ButtonChangeCell.Click += ButtonChangeCell_Click;
            // 
            // ButtonDeleteCell
            // 
            ButtonDeleteCell.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            BlockDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BlockDescription.BorderStyle = BorderStyle.Fixed3D;
            BlockDescription.Location = new Point(12, 304);
            BlockDescription.Name = "BlockDescription";
            BlockDescription.Size = new Size(273, 87);
            BlockDescription.TabIndex = 8;
            BlockDescription.Text = "Описание:";
            // 
            // MenuTools
            // 
            MenuTools.GripStyle = ToolStripGripStyle.Hidden;
            MenuTools.Items.AddRange(new ToolStripItem[] { Files, toolStripBtnAbout });
            MenuTools.Location = new Point(5, 5);
            MenuTools.Name = "MenuTools";
            MenuTools.RenderMode = ToolStripRenderMode.System;
            MenuTools.Size = new Size(790, 25);
            MenuTools.TabIndex = 9;
            // 
            // Files
            // 
            Files.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Files.DropDownItems.AddRange(new ToolStripItem[] { ImportToolStripMenuItem, ExportToolStripMenuItem });
            Files.Image = Properties.Resources.icons8_импорт_базы_данных_24;
            Files.ImageTransparentColor = Color.Magenta;
            Files.Name = "Files";
            Files.Size = new Size(29, 22);
            // 
            // ImportToolStripMenuItem
            // 
            ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            ImportToolStripMenuItem.Size = new Size(119, 22);
            ImportToolStripMenuItem.Text = "Иморт";
            ImportToolStripMenuItem.Click += ImportToolStripMenuItem_Click;
            // 
            // ExportToolStripMenuItem
            // 
            ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            ExportToolStripMenuItem.Size = new Size(119, 22);
            ExportToolStripMenuItem.Text = "Экспорт";
            ExportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            // 
            // toolStripBtnAbout
            // 
            toolStripBtnAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnAbout.Image = (Image)resources.GetObject("toolStripBtnAbout.Image");
            toolStripBtnAbout.ImageTransparentColor = Color.Magenta;
            toolStripBtnAbout.Name = "toolStripBtnAbout";
            toolStripBtnAbout.Size = new Size(67, 22);
            toolStripBtnAbout.Text = "О проекте";
            toolStripBtnAbout.Click += ToolStripBtnAbout_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuTools);
            Controls.Add(BlockDescription);
            Controls.Add(ButtonDeleteCell);
            Controls.Add(ButtonChangeCell);
            Controls.Add(ButtonCreateCell);
            Controls.Add(ButtonDeleteBlock);
            Controls.Add(ButtonChangeBlock);
            Controls.Add(ButtonCreateBlock);
            Controls.Add(ListCells);
            Controls.Add(ListBlocks);
            MinimumSize = new Size(816, 489);
            Name = "Main";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passhide";
            MenuTools.ResumeLayout(false);
            MenuTools.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStrip MenuTools;
        private ToolStripDropDownButton Files;
        private ToolStripMenuItem ImportToolStripMenuItem;
        private ToolStripMenuItem ExportToolStripMenuItem;
        private ToolStripButton toolStripBtnAbout;
    }
}
