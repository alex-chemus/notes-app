namespace Notes
{
    partial class CalculatorView
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
            expressionBox = new TextBox();
            submitButton = new Button();
            title = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            resetButton = new Button();
            resultLabel = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // expressionBox
            // 
            expressionBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            expressionBox.Location = new Point(3, 4);
            expressionBox.Margin = new Padding(3, 4, 3, 4);
            expressionBox.Name = "expressionBox";
            expressionBox.Size = new Size(460, 32);
            expressionBox.TabIndex = 0;
            // 
            // submitButton
            // 
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.Location = new Point(469, 4);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(86, 41);
            submitButton.TabIndex = 1;
            submitButton.Text = "Ввод";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(60, 67);
            title.Margin = new Padding(3, 0, 3, 20);
            title.Name = "title";
            title.Size = new Size(159, 33);
            title.TabIndex = 2;
            title.Text = "Калькулятор";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(title);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(resultLabel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(57, 67, 57, 67);
            flowLayoutPanel1.Size = new Size(807, 293);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(expressionBox);
            flowLayoutPanel2.Controls.Add(submitButton);
            flowLayoutPanel2.Controls.Add(resetButton);
            flowLayoutPanel2.Location = new Point(60, 124);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 13);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(650, 49);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // resetButton
            // 
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(561, 4);
            resetButton.Margin = new Padding(3, 4, 3, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(86, 41);
            resetButton.TabIndex = 2;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(60, 186);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(61, 24);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "label2";
            // 
            // CalculatorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(807, 293);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalculatorView";
            Text = "Calculator";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox expressionBox;
        private Button submitButton;
        private Label title;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button resetButton;
        private Label resultLabel;
    }
}