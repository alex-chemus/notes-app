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
            SuspendLayout();
            // 
            // createNoteButton
            // 
            createNoteButton.Cursor = Cursors.Hand;
            createNoteButton.Location = new Point(37, 40);
            createNoteButton.Name = "createNoteButton";
            createNoteButton.Size = new Size(164, 23);
            createNoteButton.TabIndex = 0;
            createNoteButton.Text = "Создать заметку";
            createNoteButton.UseVisualStyleBackColor = true;
            createNoteButton.Click += button1_Click;
            // 
            // calendar
            // 
            calendar.Location = new Point(37, 89);
            calendar.Name = "calendar";
            calendar.TabIndex = 1;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // showNotesButton
            // 
            showNotesButton.Location = new Point(37, 263);
            showNotesButton.Name = "showNotesButton";
            showNotesButton.Size = new Size(164, 23);
            showNotesButton.TabIndex = 2;
            showNotesButton.Text = "Показать заметки";
            showNotesButton.UseVisualStyleBackColor = true;
            showNotesButton.Click += showNotesButton_Click;
            // 
            // notesListView
            // 
            notesListView.Location = new Point(37, 327);
            notesListView.Name = "notesListView";
            notesListView.Size = new Size(406, 97);
            notesListView.TabIndex = 4;
            notesListView.UseCompatibleStateImageBehavior = false;
            notesListView.View = View.Tile;
            notesListView.MouseClick += notesListView_MouseClick;
            // 
            // NotesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 610);
            Controls.Add(notesListView);
            Controls.Add(showNotesButton);
            Controls.Add(calendar);
            Controls.Add(createNoteButton);
            Name = "NotesList";
            Text = "Список заметок";
            FormClosed += NotesList_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button createNoteButton;
        private MonthCalendar calendar;
        private Button showNotesButton;
        private ListView notesListView;
    }
}