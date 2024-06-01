namespace SchoolM8
{
    partial class StudentAttendance
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnNFC = new Button();
            pictureBox2 = new PictureBox();
            btnQR = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_105;
            pictureBox1.Location = new Point(34, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNFC);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnQR);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(135, 15);
            button2.Name = "button2";
            button2.Size = new Size(144, 52);
            button2.TabIndex = 13;
            button2.Text = "Entry ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(334, 15);
            button1.Name = "button1";
            button1.Size = new Size(144, 52);
            button1.TabIndex = 12;
            button1.Text = "Exit ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnNFC
            // 
            btnNFC.BackColor = Color.FromArgb(249, 115, 22);
            btnNFC.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            btnNFC.FlatAppearance.BorderSize = 0;
            btnNFC.FlatStyle = FlatStyle.Flat;
            btnNFC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnNFC.ForeColor = Color.White;
            btnNFC.Location = new Point(334, 92);
            btnNFC.Name = "btnNFC";
            btnNFC.Size = new Size(245, 52);
            btnNFC.TabIndex = 11;
            btnNFC.Text = "NFC";
            btnNFC.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1;
            pictureBox2.Location = new Point(334, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 245);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnQR
            // 
            btnQR.BackColor = Color.FromArgb(249, 115, 22);
            btnQR.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            btnQR.FlatAppearance.BorderSize = 0;
            btnQR.FlatStyle = FlatStyle.Flat;
            btnQR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnQR.ForeColor = Color.White;
            btnQR.Location = new Point(34, 92);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(245, 52);
            btnQR.TabIndex = 9;
            btnQR.Text = "QR CODE";
            btnQR.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderColor = Color.FromArgb(249, 115, 22);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(34, 464);
            button3.Name = "button3";
            button3.Size = new Size(144, 52);
            button3.TabIndex = 14;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // StudentAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "StudentAttendance";
            Size = new Size(661, 533);
            Load += StudentAttendance_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnQR;
        private Button btnNFC;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}
