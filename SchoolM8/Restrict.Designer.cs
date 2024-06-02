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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            comboBoxStudents = new ComboBox();
            comboBoxItems = new ComboBox();
            removeRestrictionButton = new Button();
            parentRestrictionsGridView = new DataGridView();
            studentRestrictionsGridView = new DataGridView();
            button1 = new Button();
            buttonApplyRestriction = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parentRestrictionsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentRestrictionsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(comboBoxItems);
            panel1.Controls.Add(removeRestrictionButton);
            panel1.Controls.Add(parentRestrictionsGridView);
            panel1.Controls.Add(studentRestrictionsGridView);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonApplyRestriction);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 151);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 16;
            label2.Text = "Restricted Products";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(comboBoxStudents);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 45);
            panel3.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 45);
            panel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 15;
            label1.Text = "Select Student :";
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(189, 3);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(463, 38);
            comboBoxStudents.TabIndex = 15;
            // 
            // comboBoxItems
            // 
            comboBoxItems.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxItems.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(17, 77);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(463, 38);
            comboBoxItems.TabIndex = 1;
            // 
            // removeRestrictionButton
            // 
            removeRestrictionButton.BackColor = Color.FromArgb(249, 115, 22);
            removeRestrictionButton.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            removeRestrictionButton.FlatAppearance.BorderSize = 0;
            removeRestrictionButton.FlatStyle = FlatStyle.Flat;
            removeRestrictionButton.ForeColor = Color.White;
            removeRestrictionButton.Location = new Point(486, 299);
            removeRestrictionButton.Name = "removeRestrictionButton";
            removeRestrictionButton.Size = new Size(169, 44);
            removeRestrictionButton.TabIndex = 17;
            removeRestrictionButton.Text = "Allow";
            removeRestrictionButton.UseVisualStyleBackColor = false;
            removeRestrictionButton.Click += removeRestrictionButton_Click_1;
            // 
            // parentRestrictionsGridView
            // 
            parentRestrictionsGridView.AllowUserToAddRows = false;
            parentRestrictionsGridView.AllowUserToDeleteRows = false;
            parentRestrictionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parentRestrictionsGridView.BackgroundColor = Color.FromArgb(249, 115, 22);
            parentRestrictionsGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            parentRestrictionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            parentRestrictionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            parentRestrictionsGridView.DefaultCellStyle = dataGridViewCellStyle10;
            parentRestrictionsGridView.GridColor = Color.FromArgb(249, 115, 22);
            parentRestrictionsGridView.Location = new Point(6, 358);
            parentRestrictionsGridView.Name = "parentRestrictionsGridView";
            parentRestrictionsGridView.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            parentRestrictionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            parentRestrictionsGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            parentRestrictionsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            parentRestrictionsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            parentRestrictionsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            parentRestrictionsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            parentRestrictionsGridView.Size = new Size(649, 114);
            parentRestrictionsGridView.TabIndex = 16;
            // 
            // studentRestrictionsGridView
            // 
            studentRestrictionsGridView.AllowUserToAddRows = false;
            studentRestrictionsGridView.AllowUserToDeleteRows = false;
            studentRestrictionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentRestrictionsGridView.BackgroundColor = Color.FromArgb(249, 115, 22);
            studentRestrictionsGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            studentRestrictionsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            studentRestrictionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            studentRestrictionsGridView.DefaultCellStyle = dataGridViewCellStyle14;
            studentRestrictionsGridView.GridColor = Color.FromArgb(249, 115, 22);
            studentRestrictionsGridView.Location = new Point(6, 186);
            studentRestrictionsGridView.Name = "studentRestrictionsGridView";
            studentRestrictionsGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            studentRestrictionsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            studentRestrictionsGridView.RowsDefaultCellStyle = dataGridViewCellStyle16;
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            studentRestrictionsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            studentRestrictionsGridView.Size = new Size(649, 107);
            studentRestrictionsGridView.TabIndex = 14;
            studentRestrictionsGridView.CellContentClick += studentRestrictionsGridView_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(486, 478);
            button1.Name = "button1";
            button1.Size = new Size(169, 44);
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
            buttonApplyRestriction.Location = new Point(486, 71);
            buttonApplyRestriction.Name = "buttonApplyRestriction";
            buttonApplyRestriction.Size = new Size(169, 44);
            buttonApplyRestriction.TabIndex = 10;
            buttonApplyRestriction.Text = "Restriction";
            buttonApplyRestriction.UseVisualStyleBackColor = false;
            buttonApplyRestriction.Click += buttonApplyRestriction_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 323);
            label3.Name = "label3";
            label3.Size = new Size(403, 32);
            label3.TabIndex = 20;
            label3.Text = "Restricted Products For All Students";
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
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parentRestrictionsGridView).EndInit();
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
        private DataGridView studentRestrictionsGridView;
        private ComboBox comboBoxStudents;
        private DataGridView parentRestrictionsGridView;
        private Button removeRestrictionButton;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label3;
    }
}
