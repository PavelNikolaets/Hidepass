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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // InputName
            // 
            InputName.Location = new Point(3, 3);
            InputName.Name = "InputName";
            InputName.PlaceholderText = "Название";
            InputName.Size = new Size(307, 23);
            InputName.TabIndex = 0;
            // 
            // InputDescription
            // 
            InputDescription.Location = new Point(3, 32);
            InputDescription.Multiline = true;
            InputDescription.Name = "InputDescription";
            InputDescription.PlaceholderText = "Описание";
            InputDescription.ScrollBars = ScrollBars.Vertical;
            InputDescription.Size = new Size(307, 185);
            InputDescription.TabIndex = 1;
            // 
            // ButtonChange
            // 
            ButtonChange.Location = new Point(3, 223);
            ButtonChange.Name = "ButtonChange";
            ButtonChange.Size = new Size(307, 54);
            ButtonChange.TabIndex = 2;
            ButtonChange.Text = "Изменить";
            ButtonChange.UseVisualStyleBackColor = true;
            ButtonChange.Click += ButtonChange_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(InputName);
            flowLayoutPanel1.Controls.Add(InputDescription);
            flowLayoutPanel1.Controls.Add(ButtonChange);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(313, 290);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // FChangeBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(334, 311);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimizeBox = false;
            MinimumSize = new Size(350, 350);
            Name = "FChangeBlock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение блока";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputName;
        private TextBox InputDescription;
        private Button ButtonChange;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}