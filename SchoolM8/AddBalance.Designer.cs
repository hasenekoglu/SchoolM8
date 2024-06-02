namespace SchoolM8
{
    partial class AddBalance
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
            components = new System.ComponentModel.Container();
            panel12 = new Panel();
            textBoxBalance = new MaskedTextBox();
            labelCurrentBalance = new Label();
            comboBoxStudents = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            buttonUpdateBalance = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            button2 = new Button();
            panel12.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.Controls.Add(textBoxBalance);
            panel12.Controls.Add(labelCurrentBalance);
            panel12.Controls.Add(comboBoxStudents);
            panel12.Controls.Add(flowLayoutPanel1);
            panel12.Location = new Point(19, 90);
            panel12.Name = "panel12";
            panel12.Size = new Size(614, 181);
            panel12.TabIndex = 3;
            // 
            // textBoxBalance
            // 
            textBoxBalance.BackColor = Color.FromArgb(254, 215, 170);
            textBoxBalance.BorderStyle = BorderStyle.None;
            textBoxBalance.Dock = DockStyle.Top;
            textBoxBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBalance.Location = new Point(213, 70);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new Size(401, 32);
            textBoxBalance.TabIndex = 0;
            textBoxBalance.ValidatingType = typeof(int);
            // 
            // labelCurrentBalance
            // 
            labelCurrentBalance.AutoSize = true;
            labelCurrentBalance.Dock = DockStyle.Top;
            labelCurrentBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelCurrentBalance.Location = new Point(213, 38);
            labelCurrentBalance.Name = "labelCurrentBalance";
            labelCurrentBalance.Size = new Size(24, 32);
            labelCurrentBalance.TabIndex = 8;
            labelCurrentBalance.Text = "-";
            labelCurrentBalance.Click += label5_Click;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.BackColor = Color.FromArgb(254, 215, 170);
            comboBoxStudents.Dock = DockStyle.Top;
            comboBoxStudents.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(213, 0);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(401, 38);
            comboBoxStudents.TabIndex = 7;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 181);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.ForeColor = Color.FromArgb(67, 20, 7);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(180, 32);
            label8.TabIndex = 15;
            label8.Text = "Select Student :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(67, 20, 7);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 0;
            label1.Text = "Current Balance :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.FromArgb(67, 20, 7);
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 2;
            label2.Text = "Add Balance :";
            // 
            // button1
            // 
            button1.Location = new Point(3, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 0);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBalance
            // 
            buttonUpdateBalance.BackColor = Color.FromArgb(249, 115, 22);
            buttonUpdateBalance.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            buttonUpdateBalance.FlatAppearance.BorderSize = 0;
            buttonUpdateBalance.FlatStyle = FlatStyle.Flat;
            buttonUpdateBalance.ForeColor = Color.White;
            buttonUpdateBalance.Location = new Point(379, 300);
            buttonUpdateBalance.Name = "buttonUpdateBalance";
            buttonUpdateBalance.Size = new Size(254, 52);
            buttonUpdateBalance.TabIndex = 3;
            buttonUpdateBalance.Text = "Update Balance";
            buttonUpdateBalance.UseVisualStyleBackColor = false;
            buttonUpdateBalance.Click += buttonUpdateBalance_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(buttonUpdateBalance);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(119, 300);
            button2.Name = "button2";
            button2.Size = new Size(254, 52);
            button2.TabIndex = 4;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddBalance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddBalance";
            Size = new Size(661, 533);
            Load += AddBalance_Load;
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel12;
        private Button buttonUpdateBalance;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label labelCurrentBalance;
        private ComboBox comboBoxStudents;
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox textBoxBalance;
        private Panel panel1;
        private Button button2;
    }
}
