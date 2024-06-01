namespace SchoolM8
{
    partial class AddCanteenDetails
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
            textBoxItemName = new TextBox();
            textBoxPrice = new TextBox();
            numericUpDownStock = new NumericUpDown();
            buttonAddItem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBoxItems = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxItemName
            // 
            textBoxItemName.BorderStyle = BorderStyle.None;
            textBoxItemName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBoxItemName.Location = new Point(29, 49);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(227, 32);
            textBoxItemName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            textBoxPrice.Location = new Point(279, 50);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(97, 32);
            textBoxPrice.TabIndex = 1;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.BorderStyle = BorderStyle.None;
            numericUpDownStock.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            numericUpDownStock.ImeMode = ImeMode.NoControl;
            numericUpDownStock.Location = new Point(408, 46);
            numericUpDownStock.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(75, 35);
            numericUpDownStock.TabIndex = 2;
            numericUpDownStock.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // buttonAddItem
            // 
            buttonAddItem.BackColor = Color.FromArgb(249, 115, 22);
            buttonAddItem.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonAddItem.FlatAppearance.BorderSize = 0;
            buttonAddItem.FlatStyle = FlatStyle.Flat;
            buttonAddItem.ForeColor = Color.White;
            buttonAddItem.Location = new Point(499, 46);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(160, 36);
            buttonAddItem.TabIndex = 10;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = false;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(29, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 11;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(279, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 12;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(408, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 32);
            label3.TabIndex = 13;
            label3.Text = "Stock";
            // 
            // listBoxItems
            // 
            listBoxItems.BorderStyle = BorderStyle.None;
            listBoxItems.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBoxItems.FormattingEnabled = true;
            listBoxItems.ItemHeight = 20;
            listBoxItems.Location = new Point(11, 183);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(648, 240);
            listBoxItems.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(499, 148);
            button1.Name = "button1";
            button1.Size = new Size(73, 32);
            button1.TabIndex = 17;
            button1.Text = "Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(578, 148);
            button2.Name = "button2";
            button2.Size = new Size(73, 32);
            button2.TabIndex = 18;
            button2.Text = "Down";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(408, 148);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 19;
            label4.Text = "Stock :";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(484, 440);
            button3.Name = "button3";
            button3.Size = new Size(160, 52);
            button3.TabIndex = 20;
            button3.Text = "Delete Item";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(listBoxItems);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numericUpDownStock);
            panel1.Controls.Add(textBoxItemName);
            panel1.Controls.Add(buttonAddItem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(307, 440);
            button4.Name = "button4";
            button4.Size = new Size(160, 52);
            button4.TabIndex = 21;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AddCanteenDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddCanteenDetails";
            Size = new Size(661, 533);
            Load += AddCanteenDetails_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxItemName;
        private TextBox textBoxPrice;
        private NumericUpDown numericUpDownStock;
        private Button buttonAddItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxItems;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button button3;
        private Panel panel1;
        private Button button4;
    }
}
