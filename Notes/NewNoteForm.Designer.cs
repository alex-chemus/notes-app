namespace Notes
{
    partial class NewNoteForm
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
            title = new Label();
            datePicker = new DateTimePicker();
            titleTextBox = new TextBox();
            label1 = new Label();
            submitButton = new Button();
            textBox = new TextBox();
            backButton = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(38, 75);
            title.Name = "title";
            title.Size = new Size(95, 25);
            title.TabIndex = 1;
            title.Text = "Название";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(288, 103);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 6;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(38, 103);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(221, 23);
            titleTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 9;
            label1.Text = "Время";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(128, 255, 128);
            submitButton.Cursor = Cursors.Hand;
            submitButton.ForeColor = Color.FromArgb(0, 64, 0);
            submitButton.Location = new Point(38, 382);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 10;
            submitButton.Text = "Сохранить";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(38, 156);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(460, 203);
            textBox.TabIndex = 11;
            // 
            // backButton
            // 
            backButton.Location = new Point(38, 26);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 12;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // NewNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(566, 445);
            Controls.Add(backButton);
            Controls.Add(textBox);
            Controls.Add(submitButton);
            Controls.Add(label1);
            Controls.Add(titleTextBox);
            Controls.Add(datePicker);
            Controls.Add(title);
            Name = "NewNoteForm";
            Text = "Новая заметка";
            FormClosed += NewNoteForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private DateTimePicker datePicker;
        private TextBox titleTextBox;
        private Label label1;
        private Button submitButton;
        private TextBox textBox;
        private Button backButton;
    }
}