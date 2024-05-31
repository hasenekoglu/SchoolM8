namespace SchoolM8
{
    partial class SignUpForm
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
            panel2 = new Panel();
            button1 = new Button();
            comboBoxRole = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            btnSignUp = new Button();
            label2 = new Label();
            txtFirstName = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBoxRole);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(btnSignUp);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtFirstName);
            panel2.Location = new Point(394, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 598);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(251, 146, 60);
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(39, 535);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(230, 51);
            button1.TabIndex = 15;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = SystemColors.Menu;
            comboBoxRole.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Teacher", "Student", "Parent" });
            comboBoxRole.Location = new Point(23, 421);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(121, 45);
            comboBoxRole.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(21, 386);
            label6.Name = "label6";
            label6.Size = new Size(64, 32);
            label6.TabIndex = 13;
            label6.Text = "Role";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(21, 291);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Menu;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPassword.Location = new Point(21, 325);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 43);
            txtPassword.TabIndex = 10;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(21, 203);
            label4.Name = "label4";
            label4.Size = new Size(87, 32);
            label4.TabIndex = 9;
            label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Menu;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(21, 237);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 43);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Menu;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtLastName.Location = new Point(21, 149);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 43);
            txtLastName.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(251, 146, 60);
            btnSignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnSignUp.Location = new Point(39, 480);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(230, 51);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(21, 23);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Menu;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFirstName.Location = new Point(21, 57);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(235, 43);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 146, 60);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 620);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(251, 146, 60);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 334);
            label1.Name = "label1";
            label1.Size = new Size(276, 55);
            label1.TabIndex = 1;
            label1.Text = "WELCOME";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Görsel_2024_05_24_saat_20_12_36_2246d888;
            pictureBox1.Location = new Point(97, 129);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 186, 116);
            ClientSize = new Size(759, 620);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignUpForm";
            Text = "<";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnSignUp;
        private Label label2;
        private TextBox txtFirstName;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtLastName;
        private Label label6;
        private Label label5;
        private TextBox txtPassword;
        private ComboBox comboBoxRole;
        private Button button1;
    }
}