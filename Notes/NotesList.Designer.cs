namespace Notes
{
    partial class NotesList
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
            createNoteButton = new Button();
            calendar = new MonthCalendar();
            showNotesButton = new Button();
            notesListView = new ListView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            savingsButton = new Button();
            budgetButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // createNoteButton
            // 
            createNoteButton.AutoSize = true;
            createNoteButton.Cursor = Cursors.Hand;
            createNoteButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            createNoteButton.Location = new Point(53, 545);
            createNoteButton.Name = "createNoteButton";
            createNoteButton.Size = new Size(164, 28);
            createNoteButton.TabIndex = 0;
            createNoteButton.Text = "Создать заметку";
            createNoteButton.UseVisualStyleBackColor = true;
            createNoteButton.Click += button1_Click;
            // 
            // calendar
            // 
            calendar.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calendar.Location = new Point(1, 1);
            calendar.Margin = new Padding(1, 1, 40, 1);
            calendar.Name = "calendar";
            calendar.TabIndex = 1;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // showNotesButton
            // 
            showNotesButton.AutoSize = true;
            showNotesButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            showNotesButton.Location = new Point(51, 221);
            showNotesButton.Margin = new Padding(1, 1, 1, 20);
            showNotesButton.Name = "showNotesButton";
            showNotesButton.Size = new Size(164, 28);
            showNotesButton.TabIndex = 2;
            showNotesButton.Text = "Показать заметки";
            showNotesButton.UseVisualStyleBackColor = true;
            showNotesButton.Click += showNotesButton_Click;
            // 
            // notesListView
            // 
            notesListView.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesListView.Location = new Point(51, 270);
            notesListView.Margin = new Padding(1, 1, 1, 30);
            notesListView.Name = "notesListView";
            notesListView.Size = new Size(406, 242);
            notesListView.TabIndex = 4;
            notesListView.UseCompatibleStateImageBehavior = false;
            notesListView.View = View.Tile;
            notesListView.MouseClick += notesListView_MouseClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(showNotesButton);
            flowLayoutPanel1.Controls.Add(notesListView);
            flowLayoutPanel1.Controls.Add(createNoteButton);
            flowLayoutPanel1.Controls.Add(budgetButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(875, 739);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(calendar);
            flowLayoutPanel2.Controls.Add(savingsButton);
            flowLayoutPanel2.Location = new Point(51, 51);
            flowLayoutPanel2.Margin = new Padding(1, 1, 1, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(302, 164);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // savingsButton
            // 
            savingsButton.Location = new Point(208, 3);
            savingsButton.Name = "savingsButton";
            savingsButton.Size = new Size(91, 23);
            savingsButton.TabIndex = 5;
            savingsButton.Text = "Копилка";
            savingsButton.UseVisualStyleBackColor = true;
            savingsButton.Click += savingsButton_Click;
            // 
            // budgetButton
            // 
            budgetButton.Location = new Point(53, 586);
            budgetButton.Margin = new Padding(3, 10, 3, 3);
            budgetButton.Name = "budgetButton";
            budgetButton.Size = new Size(163, 23);
            budgetButton.TabIndex = 7;
            budgetButton.Text = "Финансы";
            budgetButton.UseVisualStyleBackColor = true;
            budgetButton.Click += budgetButton_Click;
            // 
            // NotesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(875, 739);
            Controls.Add(flowLayoutPanel1);
            Name = "NotesList";
            Text = "Список заметок";
            FormClosed += NotesList_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button createNoteButton;
        private MonthCalendar calendar;
        private Button showNotesButton;
        private ListView notesListView;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button savingsButton;
        private Button budgetButton;
    }
}