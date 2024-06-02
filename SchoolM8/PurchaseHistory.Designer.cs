namespace SchoolM8
{
    partial class PurchaseHistory
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
            button4 = new Button();
            buttonCalculateTotalSpent = new Button();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            labelTotalSpent = new Label();
            dataGridViewPurchaseHistory = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel12 = new Panel();
            labelLastName = new Label();
            labelFirstName = new Label();
            comboBoxStudents = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchaseHistory).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(buttonCalculateTotalSpent);
            panel1.Controls.Add(dateTimePickerEndDate);
            panel1.Controls.Add(dateTimePickerStartDate);
            panel1.Controls.Add(labelTotalSpent);
            panel1.Controls.Add(dataGridViewPurchaseHistory);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(comboBoxStudents);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(332, 473);
            button4.Name = "button4";
            button4.Size = new Size(149, 44);
            button4.TabIndex = 34;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonCalculateTotalSpent
            // 
            buttonCalculateTotalSpent.BackColor = Color.FromArgb(249, 115, 22);
            buttonCalculateTotalSpent.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonCalculateTotalSpent.FlatAppearance.BorderSize = 0;
            buttonCalculateTotalSpent.FlatStyle = FlatStyle.Flat;
            buttonCalculateTotalSpent.ForeColor = Color.White;
            buttonCalculateTotalSpent.Location = new Point(487, 472);
            buttonCalculateTotalSpent.Name = "buttonCalculateTotalSpent";
            buttonCalculateTotalSpent.Size = new Size(149, 45);
            buttonCalculateTotalSpent.TabIndex = 33;
            buttonCalculateTotalSpent.Text = "Calculate Total Spent";
            buttonCalculateTotalSpent.UseVisualStyleBackColor = false;
            buttonCalculateTotalSpent.Click += buttonCalculateTotalSpent_Click;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.CalendarFont = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerEndDate.CalendarMonthBackground = Color.FromArgb(254, 215, 170);
            dateTimePickerEndDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerEndDate.Location = new Point(358, 192);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(278, 33);
            dateTimePickerEndDate.TabIndex = 32;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CalendarFont = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerStartDate.CalendarMonthBackground = Color.FromArgb(254, 215, 170);
            dateTimePickerStartDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dateTimePickerStartDate.Location = new Point(358, 153);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(278, 33);
            dateTimePickerStartDate.TabIndex = 31;
            // 
            // labelTotalSpent
            // 
            labelTotalSpent.AutoSize = true;
            labelTotalSpent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelTotalSpent.Location = new Point(9, 469);
            labelTotalSpent.Name = "labelTotalSpent";
            labelTotalSpent.Size = new Size(70, 32);
            labelTotalSpent.TabIndex = 29;
            labelTotalSpent.Text = "NULL";
            // 
            // dataGridViewPurchaseHistory
            // 
            dataGridViewPurchaseHistory.AllowUserToAddRows = false;
            dataGridViewPurchaseHistory.AllowUserToDeleteRows = false;
            dataGridViewPurchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPurchaseHistory.BackgroundColor = Color.FromArgb(249, 115, 22);
            dataGridViewPurchaseHistory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPurchaseHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPurchaseHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPurchaseHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPurchaseHistory.GridColor = Color.FromArgb(249, 115, 22);
            dataGridViewPurchaseHistory.Location = new Point(12, 241);
            dataGridViewPurchaseHistory.Name = "dataGridViewPurchaseHistory";
            dataGridViewPurchaseHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPurchaseHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewPurchaseHistory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPurchaseHistory.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewPurchaseHistory.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPurchaseHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataGridViewPurchaseHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewPurchaseHistory.Size = new Size(624, 225);
            dataGridViewPurchaseHistory.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(-3, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(177, 67);
            flowLayoutPanel1.TabIndex = 28;
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
            // 
            // button1
            // 
            button1.Location = new Point(3, 67);
            button1.Name = "button1";
            button1.Size = new Size(75, 0);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(labelLastName);
            panel12.Controls.Add(labelFirstName);
            panel12.Location = new Point(172, 34);
            panel12.Name = "panel12";
            panel12.Size = new Size(489, 67);
            panel12.TabIndex = 29;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Dock = DockStyle.Top;
            labelLastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelLastName.Location = new Point(0, 32);
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
            labelFirstName.Location = new Point(0, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(70, 32);
            labelFirstName.TabIndex = 22;
            labelFirstName.Text = "NULL";
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
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // PurchaseHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PurchaseHistory";
            Size = new Size(661, 533);
            Load += PurchaseHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchaseHistory).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxStudents;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel12;
        private Label labelLastName;
        private Label labelFirstName;
        private DataGridView dataGridViewPurchaseHistory;
        private Label labelTotalSpent;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Button buttonCalculateTotalSpent;
        private Button button4;
    }
}
