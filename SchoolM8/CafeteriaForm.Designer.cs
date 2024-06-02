namespace SchoolM8
{
    partial class CafeteriaForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            restrictedItemsGridView = new DataGridView();
            button1 = new Button();
            studentPurchasesGridView = new DataGridView();
            itemComboBox = new ComboBox();
            txtBalance = new Label();
            txtStudentName = new Label();
            purchaseButton = new Button();
            lblPrice = new Label();
            lblStock = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)restrictedItemsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentPurchasesGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(restrictedItemsGridView);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(studentPurchasesGridView);
            panel1.Controls.Add(itemComboBox);
            panel1.Controls.Add(txtBalance);
            panel1.Controls.Add(txtStudentName);
            panel1.Controls.Add(purchaseButton);
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
            label2.Location = new Point(19, 333);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 15;
            label2.Text = "Purchase History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 14;
            label1.Text = "Restricted Items";
            // 
            // restrictedItemsGridView
            // 
            restrictedItemsGridView.AllowUserToAddRows = false;
            restrictedItemsGridView.AllowUserToDeleteRows = false;
            restrictedItemsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            restrictedItemsGridView.BackgroundColor = Color.FromArgb(249, 115, 22);
            restrictedItemsGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            restrictedItemsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            restrictedItemsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            restrictedItemsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            restrictedItemsGridView.GridColor = Color.FromArgb(249, 115, 22);
            restrictedItemsGridView.Location = new Point(19, 49);
            restrictedItemsGridView.Name = "restrictedItemsGridView";
            restrictedItemsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            restrictedItemsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            restrictedItemsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            restrictedItemsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            restrictedItemsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            restrictedItemsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            restrictedItemsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            restrictedItemsGridView.Size = new Size(624, 78);
            restrictedItemsGridView.TabIndex = 13;
            restrictedItemsGridView.CellContentClick += restrictedItemsGridView_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(226, 264);
            button1.Name = "button1";
            button1.Size = new Size(205, 52);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // studentPurchasesGridView
            // 
            studentPurchasesGridView.AllowUserToAddRows = false;
            studentPurchasesGridView.AllowUserToDeleteRows = false;
            studentPurchasesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentPurchasesGridView.BackgroundColor = Color.FromArgb(249, 115, 22);
            studentPurchasesGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(180, 83, 9);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            studentPurchasesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            studentPurchasesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(251, 191, 36);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            studentPurchasesGridView.DefaultCellStyle = dataGridViewCellStyle6;
            studentPurchasesGridView.GridColor = Color.FromArgb(249, 115, 22);
            studentPurchasesGridView.Location = new Point(19, 368);
            studentPurchasesGridView.Name = "studentPurchasesGridView";
            studentPurchasesGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(253, 186, 116);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(124, 45, 18);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            studentPurchasesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(217, 119, 6);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            studentPurchasesGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            studentPurchasesGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(217, 119, 6);
            studentPurchasesGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            studentPurchasesGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            studentPurchasesGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            studentPurchasesGridView.Size = new Size(624, 146);
            studentPurchasesGridView.TabIndex = 11;
            studentPurchasesGridView.CellContentClick += studentPurchasesGridView_CellContentClick;
            // 
            // itemComboBox
            // 
            itemComboBox.BackColor = Color.FromArgb(254, 215, 170);
            itemComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            itemComboBox.FormattingEnabled = true;
            itemComboBox.Location = new Point(19, 207);
            itemComboBox.Name = "itemComboBox";
            itemComboBox.Size = new Size(624, 38);
            itemComboBox.TabIndex = 10;
            // 
            // txtBalance
            // 
            txtBalance.AutoSize = true;
            txtBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBalance.Location = new Point(19, 172);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(70, 32);
            txtBalance.TabIndex = 8;
            txtBalance.Text = "NULL";
            // 
            // txtStudentName
            // 
            txtStudentName.AutoSize = true;
            txtStudentName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtStudentName.Location = new Point(19, 140);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(70, 32);
            txtStudentName.TabIndex = 7;
            txtStudentName.Text = "NULL";
            // 
            // purchaseButton
            // 
            purchaseButton.BackColor = Color.FromArgb(249, 115, 22);
            purchaseButton.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            purchaseButton.FlatAppearance.BorderSize = 0;
            purchaseButton.FlatStyle = FlatStyle.Flat;
            purchaseButton.ForeColor = Color.White;
            purchaseButton.Location = new Point(437, 264);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(206, 52);
            purchaseButton.TabIndex = 3;
            purchaseButton.Text = "Purchase";
            purchaseButton.UseVisualStyleBackColor = false;
            purchaseButton.Click += purchaseButton_Click_1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F);
            lblPrice.Location = new Point(19, 248);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(57, 25);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "NULL";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 14.25F);
            lblStock.Location = new Point(19, 280);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(57, 25);
            lblStock.TabIndex = 17;
            lblStock.Text = "NULL";
            // 
            // CafeteriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CafeteriaForm";
            Size = new Size(661, 533);
            Load += CafeteriaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)restrictedItemsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentPurchasesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button purchaseButton;
        private Label txtBalance;
        private Label txtStudentName;
        private ComboBox itemComboBox;
        private DataGridView studentPurchasesGridView;
        private Button button1;
        private Label label1;
        private DataGridView restrictedItemsGridView;
        private Label label2;
        private Label lblStock;
        private Label lblPrice;
    }
}
