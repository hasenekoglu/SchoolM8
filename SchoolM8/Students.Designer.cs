namespace SchoolM8
{
    partial class Students
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            panel1 = new Panel();
            labelEmail = new Label();
            labelBalance = new Label();
            labelClass = new Label();
            labelParentName = new Label();
            labelAddress = new Label();
            labelDOB = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            button4 = new Button();
            TimeTable = new Button();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(172, 490);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(67, 20, 7);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.FromArgb(67, 20, 7);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 2;
            label2.Text = "Last Name :";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.FromArgb(67, 20, 7);
            label3.Location = new Point(3, 64);
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
            label4.Location = new Point(3, 96);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 6;
            label4.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.ForeColor = Color.FromArgb(67, 20, 7);
            label5.Location = new Point(3, 128);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 8;
            label5.Text = "Parent Name :";
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
            // panel1
            // 
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelBalance);
            panel1.Controls.Add(labelClass);
            panel1.Controls.Add(labelParentName);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelDOB);
            panel1.Controls.Add(labelLastName);
            panel1.Controls.Add(labelFirstName);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(TimeTable);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(35, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 490);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEmail.Location = new Point(192, 230);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(70, 32);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "NULL";
            // 
            // labelBalance
            // 
            labelBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelBalance.Location = new Point(192, 195);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(70, 32);
            labelBalance.TabIndex = 11;
            labelBalance.Text = "NULL";
            // 
            // labelClass
            // 
            labelClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelClass.Location = new Point(192, 160);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(70, 32);
            labelClass.TabIndex = 10;
            labelClass.Text = "NULL";
            // 
            // labelParentName
            // 
            labelParentName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelParentName.AutoSize = true;
            labelParentName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelParentName.Location = new Point(192, 128);
            labelParentName.Name = "labelParentName";
            labelParentName.Size = new Size(70, 32);
            labelParentName.TabIndex = 9;
            labelParentName.Text = "NULL";
            // 
            // labelAddress
            // 
            labelAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelAddress.Location = new Point(192, 96);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(70, 32);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "NULL";
            // 
            // labelDOB
            // 
            labelDOB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelDOB.AutoSize = true;
            labelDOB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelDOB.Location = new Point(192, 64);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(70, 32);
            labelDOB.TabIndex = 7;
            labelDOB.Text = "NULL";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLastName.Location = new Point(192, 32);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(70, 32);
            labelLastName.TabIndex = 6;
            labelLastName.Text = "NULL";
            labelLastName.Click += label9_Click;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelFirstName.Location = new Point(192, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(70, 32);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "NULL";
            labelFirstName.Click += label8_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(153, 438);
            button4.Name = "button4";
            button4.Size = new Size(254, 52);
            button4.TabIndex = 4;
            button4.Text = "Attendance";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TimeTable
            // 
            TimeTable.BackColor = Color.FromArgb(249, 115, 22);
            TimeTable.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            TimeTable.FlatAppearance.BorderSize = 0;
            TimeTable.FlatStyle = FlatStyle.Flat;
            TimeTable.ForeColor = Color.White;
            TimeTable.Location = new Point(3, 380);
            TimeTable.Name = "TimeTable";
            TimeTable.Size = new Size(254, 52);
            TimeTable.TabIndex = 3;
            TimeTable.Text = "Time Table";
            TimeTable.UseVisualStyleBackColor = false;
            TimeTable.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(293, 380);
            button2.Name = "button2";
            button2.Size = new Size(254, 52);
            button2.TabIndex = 2;
            button2.Text = "Exam Results";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Students";
            Size = new Size(661, 533);
            Load += Students_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Panel panel1;
        private Button TimeTable;
        private Button button2;
        private Button button4;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelBalance;
        private Label labelClass;
        private Label labelParentName;
        private Label labelAddress;
        private Label labelDOB;
        private Label label8;
        private Label labelEmail;
    }
}
