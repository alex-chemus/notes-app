namespace Notes
{
    partial class AuthView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginLabel = new Label();
            passwordLabel = new Label();
            mainLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            registerButton = new Button();
            colorModeButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackgroundImageLayout = ImageLayout.Center;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(253, 112, 20);
            loginButton.Location = new Point(60, 307);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(239, 41);
            loginButton.TabIndex = 0;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = Color.FromArgb(57, 62, 70);
            loginTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.ForeColor = Color.FromArgb(238, 238, 238);
            loginTextBox.Location = new Point(3, 28);
            loginTextBox.Margin = new Padding(3, 4, 3, 4);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(236, 32);
            loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(57, 62, 70);
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.FromArgb(238, 238, 238);
            passwordTextBox.Location = new Point(3, 28);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(236, 32);
            passwordTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.FromArgb(238, 238, 238);
            loginLabel.Location = new Point(3, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(62, 24);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.FromArgb(238, 238, 238);
            passwordLabel.Location = new Point(3, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 24);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Пароль";
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Dock = DockStyle.Fill;
            mainLabel.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.ForeColor = Color.FromArgb(238, 238, 238);
            mainLabel.Location = new Point(60, 67);
            mainLabel.Margin = new Padding(3, 0, 3, 27);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(242, 33);
            mainLabel.TabIndex = 3;
            mainLabel.Text = "Авторизация";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(mainLabel);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(loginButton);
            flowLayoutPanel1.Controls.Add(registerButton);
            flowLayoutPanel1.Controls.Add(colorModeButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.ForeColor = Color.White;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(57, 67, 57, 67);
            flowLayoutPanel1.Size = new Size(371, 553);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(loginLabel);
            flowLayoutPanel3.Controls.Add(loginTextBox);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(60, 131);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 13);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(242, 64);
            flowLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(passwordLabel);
            flowLayoutPanel2.Controls.Add(passwordTextBox);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(60, 212);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 27);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(242, 64);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // registerButton
            // 
            registerButton.BackgroundImageLayout = ImageLayout.Center;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = Color.FromArgb(253, 112, 20);
            registerButton.Location = new Point(60, 356);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(239, 41);
            registerButton.TabIndex = 9;
            registerButton.Text = "Зарегистрироваться";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // colorModeButton
            // 
            colorModeButton.BackgroundImageLayout = ImageLayout.None;
            colorModeButton.FlatStyle = FlatStyle.Flat;
            colorModeButton.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorModeButton.Location = new Point(60, 404);
            colorModeButton.Name = "colorModeButton";
            colorModeButton.Size = new Size(107, 41);
            colorModeButton.TabIndex = 10;
            colorModeButton.Text = "Тема";
            colorModeButton.UseVisualStyleBackColor = true;
            colorModeButton.Click += colorModeButton_Click;
            // 
            // AuthView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 40, 41);
            ClientSize = new Size(371, 553);
            Controls.Add(flowLayoutPanel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuthView";
            Text = "Авторизация";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label loginLabel;
        private Label passwordLabel;
        private Label mainLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button registerButton;
        private Button colorModeButton;
    }
}