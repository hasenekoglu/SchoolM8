namespace SchoolM8
{
    partial class Restrict
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
            comboBoxStudents = new ComboBox();
            comboBoxItems = new ComboBox();
            studentRestrictionsGridView = new DataGridView();
            checkBoxIsRestricted = new CheckBox();
            button1 = new Button();
            buttonApplyRestriction = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentRestrictionsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxStudents);
            panel1.Controls.Add(comboBoxItems);
            panel1.Controls.Add(studentRestrictionsGridView);
            panel1.Controls.Add(checkBoxIsRestricted);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonApplyRestriction);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 0;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxStudents.Dock = DockStyle.Top;
            comboBoxStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(0, 38);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(661, 38);
            comboBoxStudents.TabIndex = 15;
            // 
            // comboBoxItems
            // 
            comboBoxItems.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxItems.Dock = DockStyle.Top;
            comboBoxItems.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(0, 0);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(661, 38);
            comboBoxItems.TabIndex = 1;
            // 
            // studentRestrictionsGridView
            // 
            studentRestrictionsGridView.AllowUserToAddRows = false;
            studentRestrictionsGridView.AllowUserToDeleteRows = false;
            studentRestrictionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentRestrictionsGridView.BackgroundColor = Color.FromArgb(249, 115, 22);
            studentRestrictionsGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            studentRestrictionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            studentRestrictionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentRestrictionsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            studentRestrictionsGridView.GridColor = Color.FromArgb(249, 115, 22);
            studentRestrictionsGridView.Location = new Point(3, 163);
            studentRestrictionsGridView.Name = "studentRestrictionsGridView";
            studentRestrictionsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            studentRestrictionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            studentRestrictionsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            studentRestrictionsGridView.Size = new Size(655, 177);
            studentRestrictionsGridView.TabIndex = 14;
            studentRestrictionsGridView.CellContentClick += studentRestrictionsGridView_CellContentClick;
            // 
            // checkBoxIsRestricted
            // 
            checkBoxIsRestricted.AutoSize = true;
            checkBoxIsRestricted.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBoxIsRestricted.Location = new Point(3, 372);
            checkBoxIsRestricted.Name = "checkBoxIsRestricted";
            checkBoxIsRestricted.Size = new Size(146, 36);
            checkBoxIsRestricted.TabIndex = 12;
            checkBoxIsRestricted.Text = "checkBox1";
            checkBoxIsRestricted.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(203, 427);
            button1.Name = "button1";
            button1.Size = new Size(193, 52);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // buttonApplyRestriction
            // 
            buttonApplyRestriction.BackColor = Color.FromArgb(249, 115, 22);
            buttonApplyRestriction.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonApplyRestriction.FlatAppearance.BorderSize = 0;
            buttonApplyRestriction.FlatStyle = FlatStyle.Flat;
            buttonApplyRestriction.ForeColor = Color.White;
            buttonApplyRestriction.Location = new Point(412, 427);
            buttonApplyRestriction.Name = "buttonApplyRestriction";
            buttonApplyRestriction.Size = new Size(193, 52);
            buttonApplyRestriction.TabIndex = 10;
            buttonApplyRestriction.Text = "Restriction";
            buttonApplyRestriction.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Restrict
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Restrict";
            Size = new Size(661, 533);
            Load += Restrict_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentRestrictionsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonApplyRestriction;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxItems;
        private CheckBox checkBoxIsRestricted;
        private DataGridView studentRestrictionsGridView;
        private ComboBox comboBoxStudents;
    }
}
