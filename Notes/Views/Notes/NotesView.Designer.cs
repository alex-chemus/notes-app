namespace Notes
{
    partial class NotesView
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
            FlowLayoutPanel mainLayoutPanel;
            flowLayoutPanel3 = new FlowLayoutPanel();
            notesButton = new Button();
            budgetButton = new Button();
            colorModeButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            calendar = new MonthCalendar();
            showNotesButton = new Button();
            notesListView = new ListView();
            noteLayoutPanel = new FlowLayoutPanel();
            titleLabel = new Label();
            dateLabel = new Label();
            noteTextLabel = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            FormPanel = new Panel();
            titleTextBox = new TextBox();
            noteTextBox = new TextBox();
            openCalcNote = new Button();
            datePicker = new DateTimePicker();
            createNoteButton = new Button();
            dateFormLabel = new Label();
            titleFormLabel = new Label();
            mainLayoutPanel = new FlowLayoutPanel();
            mainLayoutPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            noteLayoutPanel.SuspendLayout();
            FormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.Controls.Add(flowLayoutPanel3);
            mainLayoutPanel.Controls.Add(flowLayoutPanel2);
            mainLayoutPanel.Controls.Add(FormPanel);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.FlowDirection = FlowDirection.TopDown;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Padding = new Padding(50);
            mainLayoutPanel.Size = new Size(1158, 1055);
            mainLayoutPanel.TabIndex = 25;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(notesButton);
            flowLayoutPanel3.Controls.Add(budgetButton);
            flowLayoutPanel3.Controls.Add(colorModeButton);
            flowLayoutPanel3.Location = new Point(53, 53);
            flowLayoutPanel3.Margin = new Padding(3, 3, 3, 50);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(339, 49);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // notesButton
            // 
            notesButton.BackColor = Color.FromArgb(253, 112, 20);
            notesButton.FlatStyle = FlatStyle.Popup;
            notesButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesButton.ForeColor = Color.FromArgb(39, 40, 41);
            notesButton.Location = new Point(3, 4);
            notesButton.Margin = new Padding(3, 4, 3, 4);
            notesButton.Name = "notesButton";
            notesButton.Size = new Size(107, 41);
            notesButton.TabIndex = 6;
            notesButton.Text = "Заметки";
            notesButton.UseVisualStyleBackColor = false;
            // 
            // budgetButton
            // 
            budgetButton.FlatStyle = FlatStyle.Flat;
            budgetButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            budgetButton.ForeColor = Color.FromArgb(253, 112, 20);
            budgetButton.Location = new Point(116, 4);
            budgetButton.Margin = new Padding(3, 4, 3, 4);
            budgetButton.Name = "budgetButton";
            budgetButton.Size = new Size(107, 41);
            budgetButton.TabIndex = 7;
            budgetButton.Text = "Финансы";
            budgetButton.UseVisualStyleBackColor = true;
            budgetButton.Click += budgetButton_Click;
            // 
            // colorModeButton
            // 
            colorModeButton.BackgroundImageLayout = ImageLayout.None;
            colorModeButton.FlatStyle = FlatStyle.Flat;
            colorModeButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorModeButton.Location = new Point(229, 3);
            colorModeButton.Name = "colorModeButton";
            colorModeButton.Size = new Size(107, 41);
            colorModeButton.TabIndex = 11;
            colorModeButton.Text = "Тема";
            colorModeButton.UseVisualStyleBackColor = true;
            colorModeButton.Click += colorModeButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel2.Controls.Add(notesListView);
            flowLayoutPanel2.Controls.Add(noteLayoutPanel);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel2.Location = new Point(53, 155);
            flowLayoutPanel2.Margin = new Padding(3, 3, 3, 40);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(737, 303);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(calendar);
            flowLayoutPanel1.Controls.Add(showNotesButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Margin = new Padding(3, 4, 34, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(198, 287);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // calendar
            // 
            calendar.BackColor = Color.FromArgb(57, 62, 70);
            calendar.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calendar.ForeColor = Color.Magenta;
            calendar.Location = new Point(3, 4);
            calendar.Margin = new Padding(3, 4, 3, 27);
            calendar.Name = "calendar";
            calendar.RightToLeft = RightToLeft.No;
            calendar.TabIndex = 1;
            calendar.TitleBackColor = Color.IndianRed;
            calendar.TitleForeColor = Color.IndianRed;
            calendar.TrailingForeColor = Color.FromArgb(253, 112, 20);
            calendar.DateChanged += calendar_DateChanged;
            // 
            // showNotesButton
            // 
            showNotesButton.FlatStyle = FlatStyle.Flat;
            showNotesButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showNotesButton.ForeColor = Color.FromArgb(253, 112, 20);
            showNotesButton.Location = new Point(3, 242);
            showNotesButton.Margin = new Padding(3, 4, 3, 4);
            showNotesButton.Name = "showNotesButton";
            showNotesButton.Size = new Size(187, 41);
            showNotesButton.TabIndex = 9;
            showNotesButton.Text = "Показать";
            showNotesButton.UseVisualStyleBackColor = true;
            showNotesButton.Click += showNotesButton_Click;
            // 
            // notesListView
            // 
            notesListView.BackColor = Color.FromArgb(57, 62, 70);
            notesListView.BorderStyle = BorderStyle.FixedSingle;
            notesListView.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesListView.ForeColor = Color.FromArgb(238, 238, 238);
            notesListView.Location = new Point(238, 3);
            notesListView.Margin = new Padding(3, 3, 30, 3);
            notesListView.Name = "notesListView";
            notesListView.Size = new Size(323, 297);
            notesListView.TabIndex = 4;
            notesListView.UseCompatibleStateImageBehavior = false;
            notesListView.View = View.Tile;
            notesListView.MouseClick += notesListView_MouseClick;
            // 
            // noteLayoutPanel
            // 
            noteLayoutPanel.AutoSize = true;
            noteLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            noteLayoutPanel.Controls.Add(titleLabel);
            noteLayoutPanel.Controls.Add(dateLabel);
            noteLayoutPanel.Controls.Add(noteTextLabel);
            noteLayoutPanel.FlowDirection = FlowDirection.TopDown;
            noteLayoutPanel.Location = new Point(594, 3);
            noteLayoutPanel.Name = "noteLayoutPanel";
            noteLayoutPanel.Size = new Size(134, 101);
            noteLayoutPanel.TabIndex = 28;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(108, 28);
            titleLabel.TabIndex = 25;
            titleLabel.Text = "Название";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(3, 31);
            dateLabel.Margin = new Padding(3, 3, 3, 25);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 21);
            dateLabel.TabIndex = 26;
            dateLabel.Text = "Дата";
            // 
            // noteTextLabel
            // 
            noteTextLabel.AutoSize = true;
            noteTextLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            noteTextLabel.Location = new Point(3, 77);
            noteTextLabel.Name = "noteTextLabel";
            noteTextLabel.Size = new Size(128, 24);
            noteTextLabel.TabIndex = 27;
            noteTextLabel.Text = "Текст заметки";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(734, 4);
            flowLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(0, 0);
            flowLayoutPanel4.TabIndex = 16;
            // 
            // FormPanel
            // 
            FormPanel.AutoSize = true;
            FormPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormPanel.Controls.Add(titleTextBox);
            FormPanel.Controls.Add(noteTextBox);
            FormPanel.Controls.Add(openCalcNote);
            FormPanel.Controls.Add(datePicker);
            FormPanel.Controls.Add(createNoteButton);
            FormPanel.Controls.Add(dateFormLabel);
            FormPanel.Controls.Add(titleFormLabel);
            FormPanel.Location = new Point(53, 501);
            FormPanel.Name = "FormPanel";
            FormPanel.Size = new Size(584, 231);
            FormPanel.TabIndex = 26;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = Color.FromArgb(57, 62, 70);
            titleTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextBox.ForeColor = Color.FromArgb(238, 238, 238);
            titleTextBox.Location = new Point(0, 40);
            titleTextBox.Margin = new Padding(3, 4, 3, 4);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(228, 32);
            titleTextBox.TabIndex = 18;
            // 
            // noteTextBox
            // 
            noteTextBox.BackColor = Color.FromArgb(57, 62, 70);
            noteTextBox.BorderStyle = BorderStyle.FixedSingle;
            noteTextBox.ForeColor = Color.FromArgb(238, 238, 238);
            noteTextBox.Location = new Point(0, 80);
            noteTextBox.Margin = new Padding(3, 4, 3, 4);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(581, 98);
            noteTextBox.TabIndex = 20;
            // 
            // openCalcNote
            // 
            openCalcNote.FlatStyle = FlatStyle.Flat;
            openCalcNote.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            openCalcNote.ForeColor = Color.FromArgb(253, 112, 20);
            openCalcNote.Location = new Point(394, 186);
            openCalcNote.Margin = new Padding(3, 4, 3, 4);
            openCalcNote.Name = "openCalcNote";
            openCalcNote.Size = new Size(187, 41);
            openCalcNote.TabIndex = 24;
            openCalcNote.Text = "Калькулятор";
            openCalcNote.UseVisualStyleBackColor = true;
            openCalcNote.Click += openCalcNote_Click;
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.CalendarForeColor = Color.FromArgb(238, 238, 238);
            datePicker.CalendarMonthBackground = Color.FromArgb(57, 62, 70);
            datePicker.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Location = new Point(353, 40);
            datePicker.Margin = new Padding(3, 4, 3, 4);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(228, 32);
            datePicker.TabIndex = 19;
            // 
            // createNoteButton
            // 
            createNoteButton.FlatStyle = FlatStyle.Flat;
            createNoteButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createNoteButton.ForeColor = Color.FromArgb(253, 112, 20);
            createNoteButton.Location = new Point(0, 186);
            createNoteButton.Margin = new Padding(3, 4, 3, 4);
            createNoteButton.Name = "createNoteButton";
            createNoteButton.Size = new Size(187, 41);
            createNoteButton.TabIndex = 23;
            createNoteButton.Text = "Создать заметку";
            createNoteButton.UseVisualStyleBackColor = true;
            createNoteButton.Click += createNoteButton_Click;
            // 
            // dateFormLabel
            // 
            dateFormLabel.AutoSize = true;
            dateFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateFormLabel.ForeColor = Color.FromArgb(238, 238, 238);
            dateFormLabel.Location = new Point(353, 8);
            dateFormLabel.Name = "dateFormLabel";
            dateFormLabel.Size = new Size(54, 28);
            dateFormLabel.TabIndex = 22;
            dateFormLabel.Text = "Дата";
            // 
            // titleFormLabel
            // 
            titleFormLabel.AutoSize = true;
            titleFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleFormLabel.ForeColor = Color.FromArgb(238, 238, 238);
            titleFormLabel.Location = new Point(0, 8);
            titleFormLabel.Name = "titleFormLabel";
            titleFormLabel.Size = new Size(100, 28);
            titleFormLabel.TabIndex = 21;
            titleFormLabel.Text = "Название";
            // 
            // NotesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 40, 41);
            ClientSize = new Size(1158, 1055);
            Controls.Add(mainLayoutPanel);
            ForeColor = Color.FromArgb(238, 238, 238);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NotesView";
            Text = "Список заметок";
            FormClosed += NotesList_FormClosed;
            mainLayoutPanel.ResumeLayout(false);
            mainLayoutPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            noteLayoutPanel.ResumeLayout(false);
            noteLayoutPanel.PerformLayout();
            FormPanel.ResumeLayout(false);
            FormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MonthCalendar calendar;
        private ListView notesListView;
        private Button notesButton;
        private Button budgetButton;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button showNotesButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label titleFormLabel;
        private TextBox titleTextBox;
        private Label dateFormLabel;
        private DateTimePicker datePicker;
        private TextBox noteTextBox;
        private Button createNoteButton;
        private Button openCalcNote;
        private Label titleLabel;
        private Label dateLabel;
        private Label noteTextLabel;
        private FlowLayoutPanel noteLayoutPanel;
        private Panel FormPanel;
        private Button colorModeButton;
    }
}