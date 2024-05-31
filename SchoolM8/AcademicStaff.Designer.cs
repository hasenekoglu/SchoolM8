namespace SchoolM8
{
    partial class AcademicStaff
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
            labelEmail = new Label();
            labelSubject = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            button3 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label3 = new Label();
            labelPhoneNumber = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPhoneNumber);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelSubject);
            panel1.Controls.Add(labelLastName);
            panel1.Controls.Add(labelFirstName);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(42, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 472);
            panel1.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEmail.Location = new Point(221, 99);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(70, 32);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "NULL";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelSubject.Location = new Point(221, 67);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(70, 32);
            labelSubject.TabIndex = 6;
            labelSubject.Text = "NULL";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLastName.Location = new Point(221, 35);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(70, 32);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "NULL";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelFirstName.Location = new Point(221, 3);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(70, 32);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "NULL";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 380);
            button3.Name = "button3";
            button3.Size = new Size(254, 52);
            button3.TabIndex = 3;
            button3.Text = "Add Student's Marks";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(309, 380);
            button2.Name = "button2";
            button2.Size = new Size(254, 52);
            button2.TabIndex = 2;
            button2.Text = "Year Schedule";
            button2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(203, 221);
            flowLayoutPanel1.TabIndex = 1;
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
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.FromArgb(67, 20, 7);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = Color.FromArgb(67, 20, 7);
            label4.Location = new Point(3, 64);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 6;
            label4.Text = "Subject :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.ForeColor = Color.FromArgb(67, 20, 7);
            label5.Location = new Point(3, 96);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 8;
            label5.Text = "E-Mail :";
            // 
            // button1
            // 
            button1.Location = new Point(103, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 0);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.FromArgb(67, 20, 7);
            label3.Location = new Point(3, 128);
            label3.Name = "label3";
            label3.Size = new Size(189, 32);
            label3.TabIndex = 15;
            label3.Text = "Phone Number :";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelPhoneNumber.Location = new Point(221, 131);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(70, 32);
            labelPhoneNumber.TabIndex = 8;
            labelPhoneNumber.Text = "NULL";
            // 
            // AcademicStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AcademicStaff";
            Size = new Size(661, 533);
            Load += AcademicStaff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label labelEmail;
        private Label labelSubject;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelPhoneNumber;
        private Label label3;
    }
}
