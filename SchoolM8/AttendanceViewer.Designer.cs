namespace SchoolM8
{
    partial class AttendanceViewer
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridViewAttendance = new DataGridView();
            comboBoxStudents = new ComboBox();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(dataGridViewAttendance);
            panel1.Controls.Add(comboBoxStudents);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 0;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToAddRows = false;
            dataGridViewAttendance.AllowUserToDeleteRows = false;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = Color.FromArgb(249, 115, 22);
            dataGridViewAttendance.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAttendance.GridColor = Color.FromArgb(249, 115, 22);
            dataGridViewAttendance.Location = new Point(13, 44);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewAttendance.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAttendance.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewAttendance.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewAttendance.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridViewAttendance.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewAttendance.Size = new Size(624, 398);
            dataGridViewAttendance.TabIndex = 28;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxStudents.Dock = DockStyle.Top;
            comboBoxStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(0, 0);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(661, 38);
            comboBoxStudents.TabIndex = 27;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(249, 115, 22);
            button6.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(461, 461);
            button6.Name = "button6";
            button6.Size = new Size(176, 52);
            button6.TabIndex = 29;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // AttendanceViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AttendanceViewer";
            Size = new Size(661, 533);
            Load += AttendanceViewer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxStudents;
        private DataGridView dataGridViewAttendance;
        private Button button6;
    }
}
