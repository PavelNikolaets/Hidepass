namespace Hidepass.Forms.Cell
{
    partial class FViewCell
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
            LabelName = new Label();
            LabelDescription = new Label();
            LabelLogin = new Label();
            LabelPassword = new Label();
            LabelTimeCreate = new Label();
            ButtonCopyLogin = new Button();
            ButtonCopyPassword = new Button();
            LabelTimeUpdate = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            BarPasswordСomplexity = new ProgressBar();
            LblPasswordStrength = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.BorderStyle = BorderStyle.Fixed3D;
            LabelName.Location = new Point(8, 24);
            LabelName.Margin = new Padding(5);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(117, 17);
            LabelName.TabIndex = 0;
            LabelName.Text = "Название: название";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.BorderStyle = BorderStyle.Fixed3D;
            LabelDescription.Location = new Point(8, 51);
            LabelDescription.Margin = new Padding(5);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(123, 17);
            LabelDescription.TabIndex = 1;
            LabelDescription.Text = "Описание: описание";
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.BorderStyle = BorderStyle.Fixed3D;
            LabelLogin.Location = new Point(0, 5);
            LabelLogin.Margin = new Padding(0, 5, 5, 5);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(82, 17);
            LabelLogin.TabIndex = 2;
            LabelLogin.Text = "Логин: логин";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.BorderStyle = BorderStyle.Fixed3D;
            LabelPassword.Location = new Point(0, 5);
            LabelPassword.Margin = new Padding(0, 5, 5, 5);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(97, 17);
            LabelPassword.TabIndex = 3;
            LabelPassword.Text = "Пароль: пароль";
            // 
            // LabelTimeCreate
            // 
            LabelTimeCreate.AutoSize = true;
            LabelTimeCreate.BorderStyle = BorderStyle.Fixed3D;
            LabelTimeCreate.Dock = DockStyle.Fill;
            LabelTimeCreate.Location = new Point(5, 302);
            LabelTimeCreate.Margin = new Padding(5);
            LabelTimeCreate.Name = "LabelTimeCreate";
            LabelTimeCreate.Size = new Size(208, 17);
            LabelTimeCreate.TabIndex = 4;
            LabelTimeCreate.Text = "Дата создания: 00.00.0000 00:00";
            // 
            // ButtonCopyLogin
            // 
            ButtonCopyLogin.FlatStyle = FlatStyle.Popup;
            ButtonCopyLogin.Image = Properties.Resources.icons8_copy_17;
            ButtonCopyLogin.Location = new Point(90, 3);
            ButtonCopyLogin.Name = "ButtonCopyLogin";
            ButtonCopyLogin.Size = new Size(18, 18);
            ButtonCopyLogin.TabIndex = 5;
            ButtonCopyLogin.UseVisualStyleBackColor = true;
            ButtonCopyLogin.Click += ButtonCopyLogin_Click;
            // 
            // ButtonCopyPassword
            // 
            ButtonCopyPassword.FlatStyle = FlatStyle.Popup;
            ButtonCopyPassword.Image = Properties.Resources.icons8_copy_17;
            ButtonCopyPassword.Location = new Point(105, 3);
            ButtonCopyPassword.Name = "ButtonCopyPassword";
            ButtonCopyPassword.Size = new Size(18, 18);
            ButtonCopyPassword.TabIndex = 6;
            ButtonCopyPassword.UseVisualStyleBackColor = true;
            ButtonCopyPassword.Click += ButtonCopyPassword_Click;
            // 
            // LabelTimeUpdate
            // 
            LabelTimeUpdate.AutoSize = true;
            LabelTimeUpdate.BorderStyle = BorderStyle.Fixed3D;
            LabelTimeUpdate.Dock = DockStyle.Fill;
            LabelTimeUpdate.Location = new Point(5, 329);
            LabelTimeUpdate.Margin = new Padding(5);
            LabelTimeUpdate.Name = "LabelTimeUpdate";
            LabelTimeUpdate.Size = new Size(208, 17);
            LabelTimeUpdate.TabIndex = 7;
            LabelTimeUpdate.Text = "Дата изменения: 00.00.0000 00:00";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(LabelLogin);
            flowLayoutPanel1.Controls.Add(ButtonCopyLogin);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(144, 27);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(LabelPassword);
            flowLayoutPanel2.Controls.Add(ButtonCopyPassword);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 36);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(144, 27);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(LabelDescription);
            groupBox1.Controls.Add(LabelName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 92);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Основное о ячейке";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(flowLayoutPanel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 193);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Учетные данные";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel5.Controls.Add(groupBox3);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(6, 22);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(200, 149);
            flowLayoutPanel5.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(flowLayoutPanel4);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 69);
            groupBox3.Margin = new Padding(3, 3, 3, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(144, 79);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Сила пароля";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(BarPasswordСomplexity);
            flowLayoutPanel4.Controls.Add(LblPasswordStrength);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(6, 22);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(132, 35);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // BarPasswordСomplexity
            // 
            BarPasswordСomplexity.Location = new Point(3, 3);
            BarPasswordСomplexity.MarqueeAnimationSpeed = 1;
            BarPasswordСomplexity.Maximum = 5;
            BarPasswordСomplexity.Minimum = 1;
            BarPasswordСomplexity.Name = "BarPasswordСomplexity";
            BarPasswordСomplexity.Size = new Size(126, 10);
            BarPasswordСomplexity.Step = 1;
            BarPasswordСomplexity.TabIndex = 10;
            BarPasswordСomplexity.Value = 1;
            // 
            // LblPasswordStrength
            // 
            LblPasswordStrength.AutoSize = true;
            LblPasswordStrength.Location = new Point(3, 16);
            LblPasswordStrength.Name = "LblPasswordStrength";
            LblPasswordStrength.Size = new Size(101, 15);
            LblPasswordStrength.TabIndex = 13;
            LblPasswordStrength.Text = "Сила пароля: 0/5";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(groupBox1);
            flowLayoutPanel3.Controls.Add(groupBox2);
            flowLayoutPanel3.Controls.Add(LabelTimeCreate);
            flowLayoutPanel3.Controls.Add(LabelTimeUpdate);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(295, 359);
            flowLayoutPanel3.TabIndex = 12;
            // 
            // FViewCell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(295, 359);
            Controls.Add(flowLayoutPanel3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(311, 398);
            Name = "FViewCell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Просмотр ячейки";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelName;
        private Label LabelDescription;
        private Label LabelLogin;
        private Label LabelPassword;
        private Label LabelTimeCreate;
        private Button ButtonCopyLogin;
        private Button ButtonCopyPassword;
        private Label LabelTimeUpdate;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel3;
        private ProgressBar BarPasswordСomplexity;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label LblPasswordStrength;
        private FlowLayoutPanel flowLayoutPanel5;
    }
}