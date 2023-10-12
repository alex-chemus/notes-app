namespace Notes
{
    partial class Savings
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
            dateTimePicker = new DateTimePicker();
            dataGridView = new DataGridView();
            showButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            backButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            month = new DataGridViewTextBoxColumn();
            income = new DataGridViewTextBoxColumn();
            expense = new DataGridViewTextBoxColumn();
            diff = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "MM.yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(3, 3);
            dateTimePicker.Margin = new Padding(3, 3, 15, 3);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.MintCream;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { month, income, expense, diff });
            dataGridView.GridColor = SystemColors.ControlDarkDark;
            dataGridView.Location = new Point(53, 181);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(440, 552);
            dataGridView.TabIndex = 2;
            // 
            // showButton
            // 
            showButton.Location = new Point(221, 3);
            showButton.Name = "showButton";
            showButton.Size = new Size(75, 23);
            showButton.TabIndex = 3;
            showButton.Text = "Показать";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(backButton);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(dataGridView);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(928, 843);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // backButton
            // 
            backButton.Location = new Point(53, 53);
            backButton.Margin = new Padding(3, 3, 3, 50);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(dateTimePicker);
            flowLayoutPanel2.Controls.Add(showButton);
            flowLayoutPanel2.Location = new Point(53, 129);
            flowLayoutPanel2.Margin = new Padding(3, 3, 3, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(299, 29);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // month
            // 
            month.Frozen = true;
            month.HeaderText = "Месяц";
            month.Name = "month";
            // 
            // income
            // 
            income.Frozen = true;
            income.HeaderText = "Доход";
            income.Name = "income";
            // 
            // expense
            // 
            expense.Frozen = true;
            expense.HeaderText = "Расход";
            expense.Name = "expense";
            // 
            // diff
            // 
            diff.HeaderText = "Итог";
            diff.Name = "diff";
            diff.ReadOnly = true;
            // 
            // Savings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(928, 843);
            Controls.Add(flowLayoutPanel1);
            Name = "Savings";
            Text = "Savings";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private DataGridView dataGridView;
        private Button showButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button backButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridViewTextBoxColumn month;
        private DataGridViewTextBoxColumn income;
        private DataGridViewTextBoxColumn expense;
        private DataGridViewTextBoxColumn diff;
    }
}