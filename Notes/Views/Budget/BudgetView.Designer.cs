namespace Notes
{
    partial class BudgetView
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
            label2 = new Label();
            amountTextBox = new TextBox();
            incomeRadio = new RadioButton();
            expenseRadio = new RadioButton();
            label3 = new Label();
            incomeGroup = new GroupBox();
            groupBox1 = new GroupBox();
            singularRadio = new RadioButton();
            regularRadio = new RadioButton();
            periodCombo = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            submitButton = new Button();
            sumInputPanel = new Panel();
            periodComboPanel = new Panel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            notesButton = new Button();
            budgetButton = new Button();
            dataGridView = new DataGridView();
            month = new DataGridViewTextBoxColumn();
            income = new DataGridViewTextBoxColumn();
            expense = new DataGridViewTextBoxColumn();
            diff = new DataGridViewTextBoxColumn();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            incomeGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            sumInputPanel.SuspendLayout();
            periodComboPanel.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 1;
            label2.Text = "Сумма";
            // 
            // amountTextBox
            // 
            amountTextBox.BackColor = Color.FromArgb(57, 62, 70);
            amountTextBox.BorderStyle = BorderStyle.FixedSingle;
            amountTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountTextBox.ForeColor = Color.FromArgb(238, 238, 238);
            amountTextBox.Location = new Point(0, 28);
            amountTextBox.Margin = new Padding(3, 4, 3, 4);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(114, 32);
            amountTextBox.TabIndex = 2;
            // 
            // incomeRadio
            // 
            incomeRadio.AutoSize = true;
            incomeRadio.Location = new Point(31, 45);
            incomeRadio.Margin = new Padding(3, 4, 3, 4);
            incomeRadio.Name = "incomeRadio";
            incomeRadio.Size = new Size(85, 28);
            incomeRadio.TabIndex = 3;
            incomeRadio.TabStop = true;
            incomeRadio.Text = "Доход";
            incomeRadio.UseVisualStyleBackColor = true;
            // 
            // expenseRadio
            // 
            expenseRadio.AutoSize = true;
            expenseRadio.Location = new Point(31, 79);
            expenseRadio.Margin = new Padding(3, 4, 3, 4);
            expenseRadio.Name = "expenseRadio";
            expenseRadio.Size = new Size(89, 28);
            expenseRadio.TabIndex = 4;
            expenseRadio.TabStop = true;
            expenseRadio.Text = "Расход";
            expenseRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 238, 238);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(224, 24);
            label3.TabIndex = 5;
            label3.Text = "Период (если регулярно)";
            // 
            // incomeGroup
            // 
            incomeGroup.Controls.Add(incomeRadio);
            incomeGroup.Controls.Add(expenseRadio);
            incomeGroup.FlatStyle = FlatStyle.Flat;
            incomeGroup.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            incomeGroup.ForeColor = Color.FromArgb(238, 238, 238);
            incomeGroup.Location = new Point(3, 4);
            incomeGroup.Margin = new Padding(3, 4, 25, 4);
            incomeGroup.Name = "incomeGroup";
            incomeGroup.Padding = new Padding(3, 4, 3, 4);
            incomeGroup.Size = new Size(229, 133);
            incomeGroup.TabIndex = 6;
            incomeGroup.TabStop = false;
            incomeGroup.Text = "Тип операции";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(singularRadio);
            groupBox1.Controls.Add(regularRadio);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox1.Location = new Point(260, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 133);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Периодичность";
            // 
            // singularRadio
            // 
            singularRadio.AutoSize = true;
            singularRadio.Location = new Point(31, 45);
            singularRadio.Margin = new Padding(3, 4, 3, 4);
            singularRadio.Name = "singularRadio";
            singularRadio.Size = new Size(91, 28);
            singularRadio.TabIndex = 3;
            singularRadio.TabStop = true;
            singularRadio.Text = "Разово";
            singularRadio.UseVisualStyleBackColor = true;
            // 
            // regularRadio
            // 
            regularRadio.AutoSize = true;
            regularRadio.Location = new Point(31, 79);
            regularRadio.Margin = new Padding(3, 4, 3, 4);
            regularRadio.Name = "regularRadio";
            regularRadio.Size = new Size(118, 28);
            regularRadio.TabIndex = 4;
            regularRadio.TabStop = true;
            regularRadio.Text = "Регулярно";
            regularRadio.UseVisualStyleBackColor = true;
            // 
            // periodCombo
            // 
            periodCombo.BackColor = Color.FromArgb(57, 62, 70);
            periodCombo.FlatStyle = FlatStyle.Flat;
            periodCombo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            periodCombo.ForeColor = Color.FromArgb(238, 238, 238);
            periodCombo.FormattingEnabled = true;
            periodCombo.Location = new Point(0, 28);
            periodCombo.Margin = new Padding(3, 4, 3, 4);
            periodCombo.Name = "periodCombo";
            periodCombo.Size = new Size(138, 32);
            periodCombo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 238, 238);
            label4.Location = new Point(0, 3);
            label4.Name = "label4";
            label4.Size = new Size(173, 24);
            label4.TabIndex = 9;
            label4.Text = "Дата (если разово)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(238, 238, 238);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(57, 62, 70);
            dateTimePicker1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(2, 29);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 32);
            dateTimePicker1.TabIndex = 10;
            // 
            // submitButton
            // 
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.ForeColor = Color.FromArgb(253, 112, 20);
            submitButton.Location = new Point(3, 430);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(106, 41);
            submitButton.TabIndex = 11;
            submitButton.Text = "Добавить";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // sumInputPanel
            // 
            sumInputPanel.AutoSize = true;
            sumInputPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sumInputPanel.Controls.Add(label2);
            sumInputPanel.Controls.Add(amountTextBox);
            sumInputPanel.Location = new Point(3, 3);
            sumInputPanel.Margin = new Padding(3, 3, 3, 20);
            sumInputPanel.Name = "sumInputPanel";
            sumInputPanel.Size = new Size(117, 64);
            sumInputPanel.TabIndex = 13;
            // 
            // periodComboPanel
            // 
            periodComboPanel.AutoSize = true;
            periodComboPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            periodComboPanel.Controls.Add(label3);
            periodComboPanel.Controls.Add(periodCombo);
            periodComboPanel.Location = new Point(3, 254);
            periodComboPanel.Margin = new Padding(3, 3, 3, 20);
            periodComboPanel.Name = "periodComboPanel";
            periodComboPanel.Size = new Size(227, 64);
            periodComboPanel.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 341);
            panel1.Margin = new Padding(3, 3, 3, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 65);
            panel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(sumInputPanel);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(periodComboPanel);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(submitButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 105);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(498, 475);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(incomeGroup);
            flowLayoutPanel2.Controls.Add(groupBox1);
            flowLayoutPanel2.Location = new Point(3, 90);
            flowLayoutPanel2.Margin = new Padding(3, 3, 3, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(492, 141);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(notesButton);
            flowLayoutPanel3.Controls.Add(budgetButton);
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Margin = new Padding(3, 3, 3, 50);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(226, 49);
            flowLayoutPanel3.TabIndex = 17;
            // 
            // notesButton
            // 
            notesButton.FlatStyle = FlatStyle.Flat;
            notesButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesButton.ForeColor = Color.FromArgb(253, 112, 20);
            notesButton.Location = new Point(3, 4);
            notesButton.Margin = new Padding(3, 4, 3, 4);
            notesButton.Name = "notesButton";
            notesButton.Size = new Size(107, 41);
            notesButton.TabIndex = 6;
            notesButton.Text = "Заметки";
            notesButton.UseVisualStyleBackColor = false;
            notesButton.Click += notesButton_Click;
            // 
            // budgetButton
            // 
            budgetButton.BackColor = Color.FromArgb(253, 112, 20);
            budgetButton.FlatStyle = FlatStyle.Popup;
            budgetButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            budgetButton.ForeColor = Color.FromArgb(57, 62, 70);
            budgetButton.Location = new Point(116, 4);
            budgetButton.Margin = new Padding(3, 4, 3, 4);
            budgetButton.Name = "budgetButton";
            budgetButton.Size = new Size(107, 41);
            budgetButton.TabIndex = 7;
            budgetButton.Text = "Финансы";
            budgetButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.BackgroundColor = Color.FromArgb(57, 62, 70);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { month, income, expense, diff });
            dataGridView.GridColor = Color.FromArgb(238, 238, 238);
            dataGridView.Location = new Point(610, 54);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(555, 583);
            dataGridView.TabIndex = 18;
            // 
            // month
            // 
            month.Frozen = true;
            month.HeaderText = "Месяц";
            month.MinimumWidth = 6;
            month.Name = "month";
            month.Width = 125;
            // 
            // income
            // 
            income.Frozen = true;
            income.HeaderText = "Доход";
            income.MinimumWidth = 6;
            income.Name = "income";
            income.Width = 125;
            // 
            // expense
            // 
            expense.Frozen = true;
            expense.HeaderText = "Расход";
            expense.MinimumWidth = 6;
            expense.Name = "expense";
            expense.Width = 125;
            // 
            // diff
            // 
            diff.HeaderText = "Итог";
            diff.MinimumWidth = 6;
            diff.Name = "diff";
            diff.ReadOnly = true;
            diff.Width = 125;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(53, 53);
            flowLayoutPanel4.Margin = new Padding(3, 3, 50, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(504, 583);
            flowLayoutPanel4.TabIndex = 19;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel5.Controls.Add(dataGridView);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.Location = new Point(0, 0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(50);
            flowLayoutPanel5.Size = new Size(1222, 713);
            flowLayoutPanel5.TabIndex = 20;
            // 
            // BudgetView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 40, 41);
            ClientSize = new Size(1222, 713);
            Controls.Add(flowLayoutPanel5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BudgetView";
            Text = "BudgetForm";
            Load += BudgetForm_Load;
            incomeGroup.ResumeLayout(false);
            incomeGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            sumInputPanel.ResumeLayout(false);
            sumInputPanel.PerformLayout();
            periodComboPanel.ResumeLayout(false);
            periodComboPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox amountTextBox;
        private RadioButton incomeRadio;
        private RadioButton expenseRadio;
        private Label label3;
        private GroupBox incomeGroup;
        private GroupBox groupBox1;
        private RadioButton singularRadio;
        private RadioButton regularRadio;
        private ComboBox periodCombo;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button submitButton;
        private Panel sumInputPanel;
        private Panel periodComboPanel;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button notesButton;
        private Button budgetButton;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn month;
        private DataGridViewTextBoxColumn income;
        private DataGridViewTextBoxColumn expense;
        private DataGridViewTextBoxColumn diff;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
    }
}