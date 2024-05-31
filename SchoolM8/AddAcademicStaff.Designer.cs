namespace SchoolM8
{
    partial class AddAcademicStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            textBoxPhoneNum = new TextBox();
            textBoxSubject = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            comboBoxStudents = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 530);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(190, 400);
            button3.Name = "button3";
            button3.Size = new Size(193, 52);
            button3.TabIndex = 20;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(412, 400);
            button2.Name = "button2";
            button2.Size = new Size(193, 52);
            button2.TabIndex = 9;
            button2.Text = "Update Teacher";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxPhoneNum);
            panel2.Controls.Add(textBoxSubject);
            panel2.Controls.Add(textBoxLastName);
            panel2.Controls.Add(textBoxFirstName);
            panel2.Controls.Add(comboBoxStudents);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(190, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 289);
            panel2.TabIndex = 19;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.BackColor = Color.FromArgb(254, 215, 170);
            textBoxPhoneNum.BorderStyle = BorderStyle.None;
            textBoxPhoneNum.Dock = DockStyle.Top;
            textBoxPhoneNum.Font = new Font("Segoe UI", 18F);
            textBoxPhoneNum.Location = new Point(0, 134);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(458, 32);
            textBoxPhoneNum.TabIndex = 4;
            // 
            // textBoxSubject
            // 
            textBoxSubject.BackColor = Color.FromArgb(254, 215, 170);
            textBoxSubject.BorderStyle = BorderStyle.None;
            textBoxSubject.Dock = DockStyle.Top;
            textBoxSubject.Font = new Font("Segoe UI", 18F);
            textBoxSubject.Location = new Point(0, 102);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(458, 32);
            textBoxSubject.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(254, 215, 170);
            textBoxLastName.BorderStyle = BorderStyle.None;
            textBoxLastName.Dock = DockStyle.Top;
            textBoxLastName.Font = new Font("Segoe UI", 18F);
            textBoxLastName.Location = new Point(0, 70);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(458, 32);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(254, 215, 170);
            textBoxFirstName.BorderStyle = BorderStyle.None;
            textBoxFirstName.Dock = DockStyle.Top;
            textBoxFirstName.Font = new Font("Segoe UI", 18F);
            textBoxFirstName.Location = new Point(0, 38);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(458, 32);
            textBoxFirstName.TabIndex = 1;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxStudents.Dock = DockStyle.Top;
            comboBoxStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(0, 0);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(458, 38);
            comboBoxStudents.TabIndex = 0;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(190, 530);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = Color.FromArgb(67, 20, 7);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(179, 32);
            label8.TabIndex = 15;
            label8.Text = "Select Teacher :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(67, 20, 7);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.FromArgb(67, 20, 7);
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 2;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.FromArgb(67, 20, 7);
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 4;
            label3.Text = "Subject : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = Color.FromArgb(67, 20, 7);
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 6;
            label4.Text = "Phone Number:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 0);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddAcademicStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddAcademicStaff";
            Size = new Size(661, 533);
            Load += AddAcademicStaff_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Panel panel2;
        private ComboBox comboBoxClass;
        private TextBox textBoxBalance;
        private ComboBox comboBoxParents;
        private TextBox textBoxAddress;
        private TextBox textBoxSubject;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private ComboBox comboBoxStudents;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxPhoneNum;
    }
}
