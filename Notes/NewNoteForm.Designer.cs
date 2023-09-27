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
            calculatorButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(1, 1);
            title.Margin = new Padding(1);
            title.Name = "title";
            title.Size = new Size(86, 23);
            title.TabIndex = 1;
            title.Text = "Название";
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Location = new Point(243, 30);
            datePicker.Margin = new Padding(1);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 27);
            datePicker.TabIndex = 6;
            // 
            // titleTextBox
            // 
            titleTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextBox.Location = new Point(1, 30);
            titleTextBox.Margin = new Padding(1, 1, 20, 1);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(221, 27);
            titleTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(243, 1);
            label1.Margin = new Padding(1);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 9;
            label1.Text = "Время";
            // 
            // submitButton
            // 
            submitButton.AutoSize = true;
            submitButton.BackColor = Color.FromArgb(224, 224, 224);
            submitButton.Cursor = Cursors.Hand;
            submitButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.ForeColor = Color.FromArgb(0, 64, 0);
            submitButton.Location = new Point(1, 1);
            submitButton.Margin = new Padding(1, 1, 40, 1);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(85, 28);
            submitButton.TabIndex = 10;
            submitButton.Text = "Сохранить";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(51, 204);
            textBox.Margin = new Padding(1, 1, 1, 30);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(443, 203);
            textBox.TabIndex = 11;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(51, 51);
            backButton.Margin = new Padding(1, 1, 1, 50);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 28);
            backButton.TabIndex = 12;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // calculatorButton
            // 
            calculatorButton.AutoSize = true;
            calculatorButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            calculatorButton.Location = new Point(127, 1);
            calculatorButton.Margin = new Padding(1);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Size = new Size(157, 28);
            calculatorButton.TabIndex = 13;
            calculatorButton.Text = "Открыть калькулятор";
            calculatorButton.UseVisualStyleBackColor = true;
            calculatorButton.Click += calculatorButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(backButton);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(textBox);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(599, 539);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(titleTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(datePicker, 1, 1);
            tableLayoutPanel1.Location = new Point(51, 130);
            tableLayoutPanel1.Margin = new Padding(1, 1, 1, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(484, 58);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(submitButton);
            flowLayoutPanel2.Controls.Add(calculatorButton);
            flowLayoutPanel2.Location = new Point(53, 440);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(285, 30);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // NewNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(599, 539);
            Controls.Add(flowLayoutPanel1);
            Name = "NewNoteForm";
            Text = "Новая заметка";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label title;
        private DateTimePicker datePicker;
        private TextBox titleTextBox;
        private Label label1;
        private Button submitButton;
        private TextBox textBox;
        private Button backButton;
        private Button calculatorButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}