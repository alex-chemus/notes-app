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
            title = new Label();
            textBox = new TextBox();
            date = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(45, 26);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(45, 79);
            title.Name = "title";
            title.Size = new Size(38, 15);
            title.TabIndex = 1;
            title.Text = "label1";
            // 
            // textBox
            // 
            textBox.Location = new Point(45, 113);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(359, 112);
            textBox.TabIndex = 2;
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(404, 79);
            date.Name = "date";
            date.Size = new Size(38, 15);
            date.TabIndex = 3;
            date.Text = "label1";
            // 
            // NoteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(date);
            Controls.Add(textBox);
            Controls.Add(title);
            Controls.Add(backButton);
            Name = "NoteView";
            Text = "NoteView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label title;
        private TextBox textBox;
        private Label date;
    }
}