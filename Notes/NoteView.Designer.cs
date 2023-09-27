namespace Notes
{
    partial class NoteView
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
            backButton = new Button();
            textBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            title = new Label();
            date = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(51, 51);
            backButton.Margin = new Padding(1, 1, 1, 50);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 28);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(51, 167);
            textBox.Margin = new Padding(1);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(359, 112);
            textBox.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(backButton);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(textBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(479, 343);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(title);
            panel1.Controls.Add(date);
            panel1.Location = new Point(51, 130);
            panel1.Margin = new Padding(1, 1, 1, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 21);
            panel1.TabIndex = 5;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Left;
            title.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(76, 19);
            title.TabIndex = 1;
            title.Text = "Название";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Dock = DockStyle.Right;
            date.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(318, 0);
            date.Name = "date";
            date.Size = new Size(41, 19);
            date.TabIndex = 3;
            date.Text = "Дата";
            // 
            // NoteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(479, 343);
            Controls.Add(flowLayoutPanel1);
            Name = "NoteView";
            Text = "NoteView";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private TextBox textBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label date;
        private Label title;
        private Panel panel1;
    }
}