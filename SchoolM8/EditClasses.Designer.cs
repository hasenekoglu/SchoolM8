namespace SchoolM8
{
    partial class EditClasses
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
            buttonDeleteClass = new Button();
            button3 = new Button();
            buttonAssignTeacher = new Button();
            buttonAddClass = new Button();
            panel3 = new Panel();
            textBoxClassName = new TextBox();
            comboBoxClasses = new ComboBox();
            comboBoxTeachers = new ComboBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDeleteClass);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonAssignTeacher);
            panel1.Controls.Add(buttonAddClass);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 0;
            // 
            // buttonDeleteClass
            // 
            buttonDeleteClass.BackColor = Color.FromArgb(249, 115, 22);
            buttonDeleteClass.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonDeleteClass.FlatAppearance.BorderSize = 0;
            buttonDeleteClass.FlatStyle = FlatStyle.Flat;
            buttonDeleteClass.ForeColor = Color.White;
            buttonDeleteClass.Location = new Point(253, 298);
            buttonDeleteClass.Name = "buttonDeleteClass";
            buttonDeleteClass.Size = new Size(193, 52);
            buttonDeleteClass.TabIndex = 25;
            buttonDeleteClass.Text = "Delete Class";
            buttonDeleteClass.UseVisualStyleBackColor = false;
            buttonDeleteClass.Click += buttonDeleteClass_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(452, 436);
            button3.Name = "button3";
            button3.Size = new Size(193, 52);
            button3.TabIndex = 24;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonAssignTeacher
            // 
            buttonAssignTeacher.BackColor = Color.FromArgb(249, 115, 22);
            buttonAssignTeacher.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonAssignTeacher.FlatAppearance.BorderSize = 0;
            buttonAssignTeacher.FlatStyle = FlatStyle.Flat;
            buttonAssignTeacher.ForeColor = Color.White;
            buttonAssignTeacher.Location = new Point(350, 240);
            buttonAssignTeacher.Name = "buttonAssignTeacher";
            buttonAssignTeacher.Size = new Size(193, 52);
            buttonAssignTeacher.TabIndex = 23;
            buttonAssignTeacher.Text = "Assign Teacher";
            buttonAssignTeacher.UseVisualStyleBackColor = false;
            buttonAssignTeacher.Click += buttonAssignTeacher_Click_1;
            // 
            // buttonAddClass
            // 
            buttonAddClass.BackColor = Color.FromArgb(249, 115, 22);
            buttonAddClass.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonAddClass.FlatAppearance.BorderSize = 0;
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Location = new Point(452, 298);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(193, 52);
            buttonAddClass.TabIndex = 22;
            buttonAddClass.Text = "Add Class";
            buttonAddClass.UseVisualStyleBackColor = false;
            buttonAddClass.Click += buttonAddClass_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxClassName);
            panel3.Controls.Add(comboBoxClasses);
            panel3.Controls.Add(comboBoxTeachers);
            panel3.Location = new Point(195, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 231);
            panel3.TabIndex = 0;
            // 
            // textBoxClassName
            // 
            textBoxClassName.BackColor = Color.FromArgb(254, 215, 170);
            textBoxClassName.BorderStyle = BorderStyle.None;
            textBoxClassName.Dock = DockStyle.Top;
            textBoxClassName.Font = new Font("Segoe UI", 18F);
            textBoxClassName.Location = new Point(0, 66);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(450, 32);
            textBoxClassName.TabIndex = 3;
            // 
            // comboBoxClasses
            // 
            comboBoxClasses.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxClasses.Dock = DockStyle.Top;
            comboBoxClasses.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxClasses.FormattingEnabled = true;
            comboBoxClasses.Location = new Point(0, 33);
            comboBoxClasses.Name = "comboBoxClasses";
            comboBoxClasses.Size = new Size(450, 33);
            comboBoxClasses.TabIndex = 2;
            // 
            // comboBoxTeachers
            // 
            comboBoxTeachers.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxTeachers.Dock = DockStyle.Top;
            comboBoxTeachers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxTeachers.FormattingEnabled = true;
            comboBoxTeachers.Location = new Point(0, 0);
            comboBoxTeachers.Name = "comboBoxTeachers";
            comboBoxTeachers.Size = new Size(450, 33);
            comboBoxTeachers.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 234);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.FromArgb(67, 20, 7);
            label2.Location = new Point(0, 64);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 18;
            label2.Text = "Add Class :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(67, 20, 7);
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 17;
            label1.Text = "Select Class :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = Color.FromArgb(67, 20, 7);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(179, 32);
            label8.TabIndex = 16;
            label8.Text = "Select Teacher :";
            // 
            // EditClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "EditClasses";
            Size = new Size(661, 533);
            Load += EditClasses_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxTeachers;
        private ComboBox comboBoxClasses;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBoxClassName;
        private Button buttonAssignTeacher;
        private Button buttonAddClass;
        private Label label2;
        private Label label1;
        private Label label8;
        private Button button3;
        private Button buttonDeleteClass;
    }
}
