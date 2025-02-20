namespace Hidepass.CustomControl.Block
{
    partial class StripInfoBlock
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Description_StripInfoCell = new Label();
            Name_StripInfoCell = new Label();
            SuspendLayout();
            // 
            // Description_StripInfoCell
            // 
            Description_StripInfoCell.Location = new Point(3, 20);
            Description_StripInfoCell.Name = "Description_StripInfoCell";
            Description_StripInfoCell.Size = new Size(394, 101);
            Description_StripInfoCell.TabIndex = 5;
            Description_StripInfoCell.Text = "Описание Описание Описание Описание Описание Описание Описание Описание Описание ";
            // 
            // Name_StripInfoCell
            // 
            Name_StripInfoCell.Location = new Point(3, 0);
            Name_StripInfoCell.Name = "Name_StripInfoCell";
            Name_StripInfoCell.Size = new Size(394, 20);
            Name_StripInfoCell.TabIndex = 4;
            Name_StripInfoCell.Text = "Название клетки";
            // 
            // StripInfoBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Description_StripInfoCell);
            Controls.Add(Name_StripInfoCell);
            Name = "StripInfoBlock";
            Size = new Size(400, 125);
            ResumeLayout(false);
        }

        #endregion

        private Label Description_StripInfoCell;
        private Label Name_StripInfoCell;
    }
}
