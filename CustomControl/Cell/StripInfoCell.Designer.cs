namespace Hidepass.CustomControl.Cell
{
    partial class StripInfoCell
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
            Name_StripInfoCell = new Label();
            TimeCreate_StripInfoCell = new Label();
            DateUpdate_StripInfoCell = new Label();
            Description_StripInfoCell = new Label();
            Login_StripInfoCell = new TextBox();
            Password_StripInfoCell = new TextBox();
            SuspendLayout();
            // 
            // Name_StripInfoCell
            // 
            Name_StripInfoCell.Location = new Point(3, 2);
            Name_StripInfoCell.Name = "Name_StripInfoCell";
            Name_StripInfoCell.Size = new Size(394, 20);
            Name_StripInfoCell.TabIndex = 0;
            Name_StripInfoCell.Text = "Название клетки";
            // 
            // TimeCreate_StripInfoCell
            // 
            TimeCreate_StripInfoCell.AutoSize = true;
            TimeCreate_StripInfoCell.Location = new Point(339, 90);
            TimeCreate_StripInfoCell.Name = "TimeCreate_StripInfoCell";
            TimeCreate_StripInfoCell.Size = new Size(58, 15);
            TimeCreate_StripInfoCell.TabIndex = 1;
            TimeCreate_StripInfoCell.Text = "0.00 00:00";
            // 
            // DateUpdate_StripInfoCell
            // 
            DateUpdate_StripInfoCell.AutoSize = true;
            DateUpdate_StripInfoCell.Location = new Point(339, 107);
            DateUpdate_StripInfoCell.Name = "DateUpdate_StripInfoCell";
            DateUpdate_StripInfoCell.Size = new Size(58, 15);
            DateUpdate_StripInfoCell.TabIndex = 2;
            DateUpdate_StripInfoCell.Text = "0.00 00:00";
            // 
            // Description_StripInfoCell
            // 
            Description_StripInfoCell.Location = new Point(3, 22);
            Description_StripInfoCell.Name = "Description_StripInfoCell";
            Description_StripInfoCell.Size = new Size(394, 42);
            Description_StripInfoCell.TabIndex = 3;
            Description_StripInfoCell.Text = "Описание Описание Описание Описание Описание Описание Описание Описание Описание ";
            // 
            // Login_StripInfoCell
            // 
            Login_StripInfoCell.Location = new Point(3, 70);
            Login_StripInfoCell.Name = "Login_StripInfoCell";
            Login_StripInfoCell.PlaceholderText = "Логин";
            Login_StripInfoCell.Size = new Size(330, 23);
            Login_StripInfoCell.TabIndex = 4;
            Login_StripInfoCell.Text = "Логин";
            // 
            // Password_StripInfoCell
            // 
            Password_StripInfoCell.Location = new Point(3, 99);
            Password_StripInfoCell.Name = "Password_StripInfoCell";
            Password_StripInfoCell.PlaceholderText = "Пароль";
            Password_StripInfoCell.Size = new Size(330, 23);
            Password_StripInfoCell.TabIndex = 5;
            Password_StripInfoCell.Text = "Пароль";
            // 
            // StripInfoCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Password_StripInfoCell);
            Controls.Add(Login_StripInfoCell);
            Controls.Add(Description_StripInfoCell);
            Controls.Add(DateUpdate_StripInfoCell);
            Controls.Add(TimeCreate_StripInfoCell);
            Controls.Add(Name_StripInfoCell);
            Name = "StripInfoCell";
            Size = new Size(400, 125);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_StripInfoCell;
        private Label TimeCreate_StripInfoCell;
        private Label DateUpdate_StripInfoCell;
        private Label Description_StripInfoCell;
        private TextBox Login_StripInfoCell;
        private TextBox Password_StripInfoCell;
    }
}
