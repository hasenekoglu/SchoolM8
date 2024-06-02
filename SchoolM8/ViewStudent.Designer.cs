namespace SchoolM8
{
    partial class ViewStudent
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
            labelStudentID = new Label();
            button4 = new Button();
            buttonLoadStudentInfo = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelStudentID2 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            panel12 = new Panel();
            labelEmail = new Label();
            labelBalance = new Label();
            labelClassID = new Label();
            labelAddress = new Label();
            labelDateOfBirth = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            panel1 = new Panel();
            comboBoxViewStudents = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Dock = DockStyle.Top;
            labelStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelStudentID.Location = new Point(0, 0);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(70, 32);
            labelStudentID.TabIndex = 21;
            labelStudentID.Text = "NULL";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(198, 478);
            button4.Name = "button4";
            button4.Size = new Size(217, 52);
            button4.TabIndex = 16;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonLoadStudentInfo
            // 
            buttonLoadStudentInfo.BackColor = Color.FromArgb(249, 115, 22);
            buttonLoadStudentInfo.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonLoadStudentInfo.FlatAppearance.BorderSize = 0;
            buttonLoadStudentInfo.FlatStyle = FlatStyle.Flat;
            buttonLoadStudentInfo.ForeColor = Color.White;
            buttonLoadStudentInfo.Location = new Point(421, 478);
            buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            buttonLoadStudentInfo.Size = new Size(217, 52);
            buttonLoadStudentInfo.TabIndex = 14;
            buttonLoadStudentInfo.Text = "Load Student Info";
            buttonLoadStudentInfo.UseVisualStyleBackColor = false;
            buttonLoadStudentInfo.Click += buttonLoadStudentInfo_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelStudentID2);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Location = new Point(0, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(177, 326);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // labelStudentID2
            // 
            labelStudentID2.AutoSize = true;
            labelStudentID2.Font = new Font("Segoe UI", 18F);
            labelStudentID2.ForeColor = Color.FromArgb(67, 20, 7);
            labelStudentID2.Location = new Point(3, 0);
            labelStudentID2.Name = "labelStudentID2";
            labelStudentID2.Size = new Size(139, 32);
            labelStudentID2.TabIndex = 16;
            labelStudentID2.Text = "Student ID :";
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
            label3.Size = new Size(166, 32);
            label3.TabIndex = 4;
            label3.Text = "Date Of Birth :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = Color.FromArgb(67, 20, 7);
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 6;
            label4.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = Color.FromArgb(67, 20, 7);
            label6.Location = new Point(3, 160);
            label6.Name = "label6";
            label6.Size = new Size(79, 32);
            label6.TabIndex = 10;
            label6.Text = "Class :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.ForeColor = Color.FromArgb(67, 20, 7);
            label7.Location = new Point(3, 192);
            label7.Name = "label7";
            label7.Size = new Size(108, 32);
            label7.TabIndex = 12;
            label7.Text = "Balance :";
            // 
            // button1
            // 
            button1.Location = new Point(3, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 0);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = Color.FromArgb(67, 20, 7);
            label8.Location = new Point(3, 230);
            label8.Name = "label8";
            label8.Size = new Size(94, 32);
            label8.TabIndex = 15;
            label8.Text = "E-Mail :";
            // 
            // panel12
            // 
            panel12.Controls.Add(labelEmail);
            panel12.Controls.Add(labelBalance);
            panel12.Controls.Add(labelClassID);
            panel12.Controls.Add(labelAddress);
            panel12.Controls.Add(labelDateOfBirth);
            panel12.Controls.Add(labelLastName);
            panel12.Controls.Add(labelFirstName);
            panel12.Controls.Add(labelStudentID);
            panel12.Location = new Point(175, 64);
            panel12.Name = "panel12";
            panel12.Size = new Size(489, 326);
            panel12.TabIndex = 25;
            panel12.Paint += panel12_Paint;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = DockStyle.Top;
            labelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEmail.Location = new Point(0, 224);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(70, 32);
            labelEmail.TabIndex = 28;
            labelEmail.Text = "NULL";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Dock = DockStyle.Top;
            labelBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelBalance.Location = new Point(0, 192);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(70, 32);
            labelBalance.TabIndex = 27;
            labelBalance.Text = "NULL";
            // 
            // labelClassID
            // 
            labelClassID.AutoSize = true;
            labelClassID.Dock = DockStyle.Top;
            labelClassID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelClassID.Location = new Point(0, 160);
            labelClassID.Name = "labelClassID";
            labelClassID.Size = new Size(70, 32);
            labelClassID.TabIndex = 26;
            labelClassID.Text = "NULL";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Dock = DockStyle.Top;
            labelAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelAddress.Location = new Point(0, 128);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(70, 32);
            labelAddress.TabIndex = 25;
            labelAddress.Text = "NULL";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Dock = DockStyle.Top;
            labelDateOfBirth.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelDateOfBirth.Location = new Point(0, 96);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(70, 32);
            labelDateOfBirth.TabIndex = 24;
            labelDateOfBirth.Text = "NULL";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Dock = DockStyle.Top;
            labelLastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLastName.Location = new Point(0, 64);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(70, 32);
            labelLastName.TabIndex = 23;
            labelLastName.Text = "NULL";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Dock = DockStyle.Top;
            labelFirstName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelFirstName.Location = new Point(0, 32);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(70, 32);
            labelFirstName.TabIndex = 22;
            labelFirstName.Text = "NULL";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxViewStudents);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(buttonLoadStudentInfo);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel12);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 26;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxViewStudents
            // 
            comboBoxViewStudents.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxViewStudents.Dock = DockStyle.Top;
            comboBoxViewStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxViewStudents.FormattingEnabled = true;
            comboBoxViewStudents.Location = new Point(0, 0);
            comboBoxViewStudents.Name = "comboBoxViewStudents";
            comboBoxViewStudents.Size = new Size(661, 38);
            comboBoxViewStudents.TabIndex = 26;
            comboBoxViewStudents.SelectedIndexChanged += comboBoxViewStudents_SelectedIndexChanged;
            // 
            // ViewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ViewStudent";
            Size = new Size(661, 533);
            Load += ViewStudent_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelStudentID;
        private Button button4;
        private Button buttonLoadStudentInfo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label labelStudentID2;
        private Panel panel12;
        private Panel panel1;
        private ComboBox comboBoxViewStudents;
        private Label labelEmail;
        private Label labelBalance;
        private Label labelClassID;
        private Label labelAddress;
        private Label labelDateOfBirth;
        private Label labelLastName;
        private Label labelFirstName;
    }
}
