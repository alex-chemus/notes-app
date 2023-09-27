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
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // createNoteButton
            // 
            createNoteButton.AutoSize = true;
            createNoteButton.Cursor = Cursors.Hand;
            createNoteButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            createNoteButton.Location = new Point(53, 637);
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
            calendar.Location = new Point(51, 51);
            calendar.Margin = new Padding(1, 1, 1, 5);
            calendar.Name = "calendar";
            calendar.TabIndex = 1;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // showNotesButton
            // 
            showNotesButton.AutoSize = true;
            showNotesButton.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            showNotesButton.Location = new Point(51, 219);
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
            notesListView.Location = new Point(51, 268);
            notesListView.Margin = new Padding(1, 1, 1, 30);
            notesListView.Name = "notesListView";
            notesListView.Size = new Size(406, 336);
            notesListView.TabIndex = 4;
            notesListView.UseCompatibleStateImageBehavior = false;
            notesListView.View = View.Tile;
            notesListView.MouseClick += notesListView_MouseClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(calendar);
            flowLayoutPanel1.Controls.Add(showNotesButton);
            flowLayoutPanel1.Controls.Add(notesListView);
            flowLayoutPanel1.Controls.Add(createNoteButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(50);
            flowLayoutPanel1.Size = new Size(537, 739);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // NotesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(537, 739);
            Controls.Add(flowLayoutPanel1);
            Name = "NotesList";
            Text = "Список заметок";
            FormClosed += NotesList_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button createNoteButton;
        private MonthCalendar calendar;
        private Button showNotesButton;
        private ListView notesListView;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}