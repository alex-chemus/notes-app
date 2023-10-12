namespace Notes
{
    partial class BudgetForm
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
            label1 = new Label();
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
            backButton = new Button();
            incomeGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Финансы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 108);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Сумма";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(183, 105);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 2;
            // 
            // incomeRadio
            // 
            incomeRadio.AutoSize = true;
            incomeRadio.Location = new Point(27, 34);
            incomeRadio.Name = "incomeRadio";
            incomeRadio.Size = new Size(59, 19);
            incomeRadio.TabIndex = 3;
            incomeRadio.TabStop = true;
            incomeRadio.Text = "Доход";
            incomeRadio.UseVisualStyleBackColor = true;
            // 
            // expenseRadio
            // 
            expenseRadio.AutoSize = true;
            expenseRadio.Location = new Point(27, 59);
            expenseRadio.Name = "expenseRadio";
            expenseRadio.Size = new Size(63, 19);
            expenseRadio.TabIndex = 4;
            expenseRadio.TabStop = true;
            expenseRadio.Text = "Расход";
            expenseRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 268);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 5;
            label3.Text = "Период (если регулярно)";
            // 
            // incomeGroup
            // 
            incomeGroup.Controls.Add(incomeRadio);
            incomeGroup.Controls.Add(expenseRadio);
            incomeGroup.Location = new Point(136, 146);
            incomeGroup.Name = "incomeGroup";
            incomeGroup.Size = new Size(200, 100);
            incomeGroup.TabIndex = 6;
            incomeGroup.TabStop = false;
            incomeGroup.Text = "Тип операции";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(singularRadio);
            groupBox1.Controls.Add(regularRadio);
            groupBox1.Location = new Point(378, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип операции";
            // 
            // singularRadio
            // 
            singularRadio.AutoSize = true;
            singularRadio.Location = new Point(27, 34);
            singularRadio.Name = "singularRadio";
            singularRadio.Size = new Size(63, 19);
            singularRadio.TabIndex = 3;
            singularRadio.TabStop = true;
            singularRadio.Text = "Разово";
            singularRadio.UseVisualStyleBackColor = true;
            // 
            // regularRadio
            // 
            regularRadio.AutoSize = true;
            regularRadio.Location = new Point(27, 59);
            regularRadio.Name = "regularRadio";
            regularRadio.Size = new Size(83, 19);
            regularRadio.TabIndex = 4;
            regularRadio.TabStop = true;
            regularRadio.Text = "Регулярно";
            regularRadio.UseVisualStyleBackColor = true;
            // 
            // periodCombo
            // 
            periodCombo.FormattingEnabled = true;
            periodCombo.Location = new Point(289, 268);
            periodCombo.Name = "periodCombo";
            periodCombo.Size = new Size(121, 23);
            periodCombo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 311);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 9;
            label4.Text = "Дата (если разово)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(252, 311);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(136, 366);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 11;
            submitButton.Text = "Добавить";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(31, 48);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 12;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // BudgetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(submitButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(periodCombo);
            Controls.Add(groupBox1);
            Controls.Add(incomeGroup);
            Controls.Add(label3);
            Controls.Add(amountTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BudgetForm";
            Text = "BudgetForm";
            Load += BudgetForm_Load;
            incomeGroup.ResumeLayout(false);
            incomeGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Button backButton;
    }
}