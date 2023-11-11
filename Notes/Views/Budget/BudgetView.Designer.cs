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
            amountBudgetLabel = new Label();
            amountTextBox = new TextBox();
            incomeRadio = new RadioButton();
            expenseRadio = new RadioButton();
            periodTitle = new Label();
            incomeGroup = new GroupBox();
            periodBox = new GroupBox();
            singularRadio = new RadioButton();
            regularRadio = new RadioButton();
            periodCombo = new ComboBox();
            dateTitle = new Label();
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
            colorModeButton = new Button();
            dataGridView = new DataGridView();
            month = new DataGridViewTextBoxColumn();
            income = new DataGridViewTextBoxColumn();
            expense = new DataGridViewTextBoxColumn();
            diff = new DataGridViewTextBoxColumn();
            flowLayoutPanel4 = new FlowLayoutPanel();
            goalViewPanel = new FlowLayoutPanel();
            goalTitle = new Label();
            goalNameLabel = new Label();
            goalAmountLabel = new Label();
            goalDeadlineLabel = new Label();
            goalReachedLabel = new Label();
            goalRemainderLabel = new Label();
            goalTrendLabel = new Label();
            goalFormPanel = new FlowLayoutPanel();
            goalFormTitle = new Label();
            goalFormName = new Label();
            goalNameTextbox = new TextBox();
            goalFormAmount = new Label();
            goalAmountTextbox = new TextBox();
            goalFormDeadline = new Label();
            goalDeadlineDatepicker = new DateTimePicker();
            createGoalButton = new Button();
            flowLayoutPanel6 = new FlowLayoutPanel();
            incomeGroup.SuspendLayout();
            periodBox.SuspendLayout();
            sumInputPanel.SuspendLayout();
            periodComboPanel.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            goalViewPanel.SuspendLayout();
            goalFormPanel.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // amountBudgetLabel
            // 
            amountBudgetLabel.AutoSize = true;
            amountBudgetLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            amountBudgetLabel.ForeColor = Color.FromArgb(238, 238, 238);
            amountBudgetLabel.Location = new Point(3, 0);
            amountBudgetLabel.Name = "amountBudgetLabel";
            amountBudgetLabel.Size = new Size(68, 24);
            amountBudgetLabel.TabIndex = 1;
            amountBudgetLabel.Text = "Сумма";
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
            // periodTitle
            // 
            periodTitle.AutoSize = true;
            periodTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            periodTitle.ForeColor = Color.FromArgb(238, 238, 238);
            periodTitle.Location = new Point(0, 0);
            periodTitle.Name = "periodTitle";
            periodTitle.Size = new Size(224, 24);
            periodTitle.TabIndex = 5;
            periodTitle.Text = "Период (если регулярно)";
            // 
            // incomeGroup
            // 
            incomeGroup.Controls.Add(incomeRadio);
            incomeGroup.Controls.Add(expenseRadio);
            incomeGroup.FlatStyle = FlatStyle.Flat;
            incomeGroup.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            incomeGroup.ForeColor = Color.FromArgb(238, 238, 238);
            incomeGroup.Location = new Point(3, 3);
            incomeGroup.Name = "incomeGroup";
            incomeGroup.Padding = new Padding(3, 4, 3, 4);
            incomeGroup.Size = new Size(229, 133);
            incomeGroup.TabIndex = 6;
            incomeGroup.TabStop = false;
            incomeGroup.Text = "Тип операции";
            // 
            // periodBox
            // 
            periodBox.Controls.Add(singularRadio);
            periodBox.Controls.Add(regularRadio);
            periodBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            periodBox.ForeColor = Color.FromArgb(238, 238, 238);
            periodBox.Location = new Point(3, 143);
            periodBox.Margin = new Padding(3, 4, 3, 4);
            periodBox.Name = "periodBox";
            periodBox.Padding = new Padding(3, 4, 3, 4);
            periodBox.Size = new Size(229, 133);
            periodBox.TabIndex = 7;
            periodBox.TabStop = false;
            periodBox.Text = "Периодичность";
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
            // dateTitle
            // 
            dateTitle.AutoSize = true;
            dateTitle.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTitle.ForeColor = Color.FromArgb(238, 238, 238);
            dateTitle.Location = new Point(0, 3);
            dateTitle.Name = "dateTitle";
            dateTitle.Size = new Size(173, 24);
            dateTitle.TabIndex = 9;
            dateTitle.Text = "Дата (если разово)";
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
            submitButton.Location = new Point(3, 569);
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
            sumInputPanel.Controls.Add(amountBudgetLabel);
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
            periodComboPanel.Controls.Add(periodTitle);
            periodComboPanel.Controls.Add(periodCombo);
            periodComboPanel.Location = new Point(3, 393);
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
            panel1.Controls.Add(dateTitle);
            panel1.Location = new Point(3, 480);
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
            flowLayoutPanel1.Location = new Point(28, 178);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(241, 614);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(incomeGroup);
            flowLayoutPanel2.Controls.Add(periodBox);
            flowLayoutPanel2.Location = new Point(3, 90);
            flowLayoutPanel2.Margin = new Padding(3, 3, 3, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(235, 280);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(notesButton);
            flowLayoutPanel3.Controls.Add(budgetButton);
            flowLayoutPanel3.Controls.Add(colorModeButton);
            flowLayoutPanel3.Location = new Point(28, 28);
            flowLayoutPanel3.Margin = new Padding(3, 3, 3, 51);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(226, 96);
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
            // colorModeButton
            // 
            colorModeButton.BackgroundImageLayout = ImageLayout.None;
            colorModeButton.FlatStyle = FlatStyle.Flat;
            colorModeButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorModeButton.ForeColor = Color.White;
            colorModeButton.Location = new Point(3, 52);
            colorModeButton.Name = "colorModeButton";
            colorModeButton.Size = new Size(107, 41);
            colorModeButton.TabIndex = 12;
            colorModeButton.Text = "Тема";
            colorModeButton.UseVisualStyleBackColor = true;
            colorModeButton.Click += colorModeButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.BackgroundColor = Color.FromArgb(57, 62, 70);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { month, income, expense, diff });
            dataGridView.GridColor = Color.FromArgb(238, 238, 238);
            dataGridView.Location = new Point(323, 25);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(554, 871);
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
            flowLayoutPanel4.Dock = DockStyle.Left;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(25, 25);
            flowLayoutPanel4.Margin = new Padding(3, 3, 50, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(25);
            flowLayoutPanel4.Size = new Size(297, 1005);
            flowLayoutPanel4.TabIndex = 19;
            // 
            // goalViewPanel
            // 
            goalViewPanel.AutoSize = true;
            goalViewPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            goalViewPanel.Controls.Add(goalTitle);
            goalViewPanel.Controls.Add(goalNameLabel);
            goalViewPanel.Controls.Add(goalAmountLabel);
            goalViewPanel.Controls.Add(goalDeadlineLabel);
            goalViewPanel.Controls.Add(goalReachedLabel);
            goalViewPanel.Controls.Add(goalRemainderLabel);
            goalViewPanel.Controls.Add(goalTrendLabel);
            goalViewPanel.FlowDirection = FlowDirection.TopDown;
            goalViewPanel.Location = new Point(28, 28);
            goalViewPanel.Name = "goalViewPanel";
            goalViewPanel.Size = new Size(169, 237);
            goalViewPanel.TabIndex = 22;
            // 
            // goalTitle
            // 
            goalTitle.AutoSize = true;
            goalTitle.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            goalTitle.ForeColor = Color.White;
            goalTitle.Location = new Point(3, 0);
            goalTitle.Margin = new Padding(3, 0, 3, 15);
            goalTitle.Name = "goalTitle";
            goalTitle.Size = new Size(62, 28);
            goalTitle.TabIndex = 6;
            goalTitle.Text = "Цель";
            // 
            // goalNameLabel
            // 
            goalNameLabel.AutoSize = true;
            goalNameLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalNameLabel.ForeColor = Color.FromArgb(238, 238, 238);
            goalNameLabel.Location = new Point(3, 43);
            goalNameLabel.Margin = new Padding(3, 0, 3, 10);
            goalNameLabel.Name = "goalNameLabel";
            goalNameLabel.Size = new Size(97, 24);
            goalNameLabel.TabIndex = 0;
            goalNameLabel.Text = "Название:";
            // 
            // goalAmountLabel
            // 
            goalAmountLabel.AutoSize = true;
            goalAmountLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalAmountLabel.ForeColor = Color.FromArgb(238, 238, 238);
            goalAmountLabel.Location = new Point(3, 77);
            goalAmountLabel.Margin = new Padding(3, 0, 3, 10);
            goalAmountLabel.Name = "goalAmountLabel";
            goalAmountLabel.Size = new Size(73, 24);
            goalAmountLabel.TabIndex = 1;
            goalAmountLabel.Text = "Сумма:";
            // 
            // goalDeadlineLabel
            // 
            goalDeadlineLabel.AutoSize = true;
            goalDeadlineLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalDeadlineLabel.ForeColor = Color.FromArgb(238, 238, 238);
            goalDeadlineLabel.Location = new Point(3, 111);
            goalDeadlineLabel.Margin = new Padding(3, 0, 3, 10);
            goalDeadlineLabel.Name = "goalDeadlineLabel";
            goalDeadlineLabel.Size = new Size(57, 24);
            goalDeadlineLabel.TabIndex = 2;
            goalDeadlineLabel.Text = "Срок:";
            // 
            // goalReachedLabel
            // 
            goalReachedLabel.AutoSize = true;
            goalReachedLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalReachedLabel.ForeColor = Color.FromArgb(238, 238, 238);
            goalReachedLabel.Location = new Point(3, 145);
            goalReachedLabel.Margin = new Padding(3, 0, 3, 10);
            goalReachedLabel.Name = "goalReachedLabel";
            goalReachedLabel.Size = new Size(112, 24);
            goalReachedLabel.TabIndex = 3;
            goalReachedLabel.Text = "Достигнуто:";
            // 
            // goalRemainderLabel
            // 
            goalRemainderLabel.AutoSize = true;
            goalRemainderLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalRemainderLabel.ForeColor = Color.FromArgb(238, 238, 238);
            goalRemainderLabel.Location = new Point(3, 179);
            goalRemainderLabel.Margin = new Padding(3, 0, 3, 10);
            goalRemainderLabel.Name = "goalRemainderLabel";
            goalRemainderLabel.Size = new Size(82, 24);
            goalRemainderLabel.TabIndex = 4;
            goalRemainderLabel.Text = "Остаток:";
            // 
            // goalTrendLabel
            // 
            goalTrendLabel.AutoSize = true;
            goalTrendLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalTrendLabel.ForeColor = Color.FromArgb(238, 238, 238);
            goalTrendLabel.Location = new Point(3, 213);
            goalTrendLabel.Name = "goalTrendLabel";
            goalTrendLabel.Size = new Size(163, 24);
            goalTrendLabel.TabIndex = 5;
            goalTrendLabel.Text = "Будет достингуто:";
            // 
            // goalFormPanel
            // 
            goalFormPanel.AutoSize = true;
            goalFormPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            goalFormPanel.Controls.Add(goalFormTitle);
            goalFormPanel.Controls.Add(goalFormName);
            goalFormPanel.Controls.Add(goalNameTextbox);
            goalFormPanel.Controls.Add(goalFormAmount);
            goalFormPanel.Controls.Add(goalAmountTextbox);
            goalFormPanel.Controls.Add(goalFormDeadline);
            goalFormPanel.Controls.Add(goalDeadlineDatepicker);
            goalFormPanel.Controls.Add(createGoalButton);
            goalFormPanel.FlowDirection = FlowDirection.TopDown;
            goalFormPanel.Location = new Point(28, 271);
            goalFormPanel.Name = "goalFormPanel";
            goalFormPanel.Size = new Size(256, 304);
            goalFormPanel.TabIndex = 23;
            // 
            // goalFormTitle
            // 
            goalFormTitle.AutoSize = true;
            goalFormTitle.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            goalFormTitle.ForeColor = Color.White;
            goalFormTitle.Location = new Point(3, 0);
            goalFormTitle.Margin = new Padding(3, 0, 3, 20);
            goalFormTitle.Name = "goalFormTitle";
            goalFormTitle.Size = new Size(143, 28);
            goalFormTitle.TabIndex = 0;
            goalFormTitle.Text = "Создать цель";
            // 
            // goalFormName
            // 
            goalFormName.AutoSize = true;
            goalFormName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalFormName.ForeColor = Color.FromArgb(238, 238, 238);
            goalFormName.Location = new Point(3, 48);
            goalFormName.Name = "goalFormName";
            goalFormName.Size = new Size(92, 24);
            goalFormName.TabIndex = 2;
            goalFormName.Text = "Нзавание";
            // 
            // goalNameTextbox
            // 
            goalNameTextbox.BackColor = Color.FromArgb(57, 62, 70);
            goalNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            goalNameTextbox.ForeColor = Color.FromArgb(238, 238, 238);
            goalNameTextbox.Location = new Point(3, 75);
            goalNameTextbox.Margin = new Padding(3, 3, 3, 15);
            goalNameTextbox.Name = "goalNameTextbox";
            goalNameTextbox.Size = new Size(247, 27);
            goalNameTextbox.TabIndex = 1;
            // 
            // goalFormAmount
            // 
            goalFormAmount.AutoSize = true;
            goalFormAmount.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalFormAmount.ForeColor = Color.FromArgb(238, 238, 238);
            goalFormAmount.Location = new Point(3, 117);
            goalFormAmount.Name = "goalFormAmount";
            goalFormAmount.Size = new Size(68, 24);
            goalFormAmount.TabIndex = 4;
            goalFormAmount.Text = "Сумма";
            // 
            // goalAmountTextbox
            // 
            goalAmountTextbox.BackColor = Color.FromArgb(57, 62, 70);
            goalAmountTextbox.BorderStyle = BorderStyle.FixedSingle;
            goalAmountTextbox.ForeColor = Color.FromArgb(238, 238, 238);
            goalAmountTextbox.Location = new Point(3, 144);
            goalAmountTextbox.Margin = new Padding(3, 3, 3, 15);
            goalAmountTextbox.Name = "goalAmountTextbox";
            goalAmountTextbox.Size = new Size(247, 27);
            goalAmountTextbox.TabIndex = 5;
            // 
            // goalFormDeadline
            // 
            goalFormDeadline.AutoSize = true;
            goalFormDeadline.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalFormDeadline.ForeColor = Color.FromArgb(238, 238, 238);
            goalFormDeadline.Location = new Point(3, 186);
            goalFormDeadline.Name = "goalFormDeadline";
            goalFormDeadline.Size = new Size(52, 24);
            goalFormDeadline.TabIndex = 6;
            goalFormDeadline.Text = "Срок";
            // 
            // goalDeadlineDatepicker
            // 
            goalDeadlineDatepicker.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goalDeadlineDatepicker.Location = new Point(3, 213);
            goalDeadlineDatepicker.Margin = new Padding(3, 3, 3, 15);
            goalDeadlineDatepicker.Name = "goalDeadlineDatepicker";
            goalDeadlineDatepicker.Size = new Size(250, 27);
            goalDeadlineDatepicker.TabIndex = 7;
            // 
            // createGoalButton
            // 
            createGoalButton.FlatStyle = FlatStyle.Flat;
            createGoalButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createGoalButton.ForeColor = Color.FromArgb(253, 112, 20);
            createGoalButton.Location = new Point(3, 259);
            createGoalButton.Margin = new Padding(3, 4, 3, 4);
            createGoalButton.Name = "createGoalButton";
            createGoalButton.Size = new Size(106, 41);
            createGoalButton.TabIndex = 12;
            createGoalButton.Text = "Создать";
            createGoalButton.UseVisualStyleBackColor = true;
            createGoalButton.Click += createGoalButton_Click;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel6.Controls.Add(goalViewPanel);
            flowLayoutPanel6.Controls.Add(goalFormPanel);
            flowLayoutPanel6.Dock = DockStyle.Right;
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(1089, 25);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(25);
            flowLayoutPanel6.Size = new Size(312, 1005);
            flowLayoutPanel6.TabIndex = 24;
            // 
            // BudgetView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 40, 41);
            ClientSize = new Size(1426, 1055);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(dataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BudgetView";
            Padding = new Padding(25);
            Text = "BudgetForm";
            Load += BudgetForm_Load;
            incomeGroup.ResumeLayout(false);
            incomeGroup.PerformLayout();
            periodBox.ResumeLayout(false);
            periodBox.PerformLayout();
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
            goalViewPanel.ResumeLayout(false);
            goalViewPanel.PerformLayout();
            goalFormPanel.ResumeLayout(false);
            goalFormPanel.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label amountBudgetLabel;
        private TextBox amountTextBox;
        private RadioButton incomeRadio;
        private RadioButton expenseRadio;
        private Label periodTitle;
        private GroupBox incomeGroup;
        private GroupBox periodBox;
        private RadioButton singularRadio;
        private RadioButton regularRadio;
        private ComboBox periodCombo;
        private Label dateTitle;
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
        private FlowLayoutPanel goalViewPanel;
        private Label goalNameLabel;
        private Label goalAmountLabel;
        private Label goalDeadlineLabel;
        private Label goalReachedLabel;
        private Label goalRemainderLabel;
        private Label goalTitle;
        private Label goalTrendLabel;
        private FlowLayoutPanel goalFormPanel;
        private Label goalFormTitle;
        private Label goalFormName;
        private TextBox goalNameTextbox;
        private Label goalFormAmount;
        private TextBox goalAmountTextbox;
        private Label goalFormDeadline;
        private DateTimePicker goalDeadlineDatepicker;
        private Button createGoalButton;
        private FlowLayoutPanel flowLayoutPanel6;
        private Button colorModeButton;
    }
}