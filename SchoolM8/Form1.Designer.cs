namespace SchoolM8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            btnAdmin = new Button();
            btnParent = new Button();
            btnCanteen = new Button();
            btnAcademicStaff = new Button();
            btnStudent = new Button();
            btnDashboard = new Button();
            panelLogo = new Panel();
            labelRole = new Label();
            labelLastName = new Label();
            pictureBox1 = new PictureBox();
            labelFirstName = new Label();
            panel1 = new Panel();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(251, 146, 60);
            panelSideMenu.Controls.Add(btnAdmin);
            panelSideMenu.Controls.Add(btnParent);
            panelSideMenu.Controls.Add(btnCanteen);
            panelSideMenu.Controls.Add(btnAcademicStaff);
            panelSideMenu.Controls.Add(btnStudent);
            panelSideMenu.Controls.Add(btnDashboard);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 561);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panel1_Paint;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.Gainsboro;
            btnAdmin.Image = Properties.Resources.admin_panel_settings;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 372);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(10, 0, 0, 0);
            btnAdmin.Size = new Size(250, 54);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Admin";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnParent
            // 
            btnParent.Dock = DockStyle.Top;
            btnParent.FlatAppearance.BorderSize = 0;
            btnParent.FlatStyle = FlatStyle.Flat;
            btnParent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnParent.ForeColor = Color.Gainsboro;
            btnParent.Image = Properties.Resources.Vector_1;
            btnParent.ImageAlign = ContentAlignment.MiddleLeft;
            btnParent.Location = new Point(0, 318);
            btnParent.Name = "btnParent";
            btnParent.Padding = new Padding(10, 0, 0, 0);
            btnParent.Size = new Size(250, 54);
            btnParent.TabIndex = 4;
            btnParent.Text = "Parent";
            btnParent.TextAlign = ContentAlignment.MiddleLeft;
            btnParent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnParent.UseVisualStyleBackColor = true;
            btnParent.Click += btnParent_Click;
            // 
            // btnCanteen
            // 
            btnCanteen.Dock = DockStyle.Top;
            btnCanteen.FlatAppearance.BorderSize = 0;
            btnCanteen.FlatStyle = FlatStyle.Flat;
            btnCanteen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCanteen.ForeColor = Color.Gainsboro;
            btnCanteen.Image = Properties.Resources.Vector;
            btnCanteen.ImageAlign = ContentAlignment.MiddleLeft;
            btnCanteen.Location = new Point(0, 264);
            btnCanteen.Name = "btnCanteen";
            btnCanteen.Padding = new Padding(10, 0, 0, 0);
            btnCanteen.Size = new Size(250, 54);
            btnCanteen.TabIndex = 3;
            btnCanteen.Text = "Canteen";
            btnCanteen.TextAlign = ContentAlignment.MiddleLeft;
            btnCanteen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCanteen.UseVisualStyleBackColor = true;
            btnCanteen.Click += btnCanteen_Click;
            // 
            // btnAcademicStaff
            // 
            btnAcademicStaff.Dock = DockStyle.Top;
            btnAcademicStaff.FlatAppearance.BorderSize = 0;
            btnAcademicStaff.FlatStyle = FlatStyle.Flat;
            btnAcademicStaff.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAcademicStaff.ForeColor = Color.Gainsboro;
            btnAcademicStaff.Image = Properties.Resources.people;
            btnAcademicStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcademicStaff.Location = new Point(0, 210);
            btnAcademicStaff.Name = "btnAcademicStaff";
            btnAcademicStaff.Padding = new Padding(10, 0, 0, 0);
            btnAcademicStaff.Size = new Size(250, 54);
            btnAcademicStaff.TabIndex = 2;
            btnAcademicStaff.Text = "Academic Staff";
            btnAcademicStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnAcademicStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcademicStaff.UseVisualStyleBackColor = true;
            btnAcademicStaff.Click += btnAcademicStaff_Click;
            // 
            // btnStudent
            // 
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnStudent.ForeColor = Color.Gainsboro;
            btnStudent.Image = Properties.Resources.students_1;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(0, 156);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(10, 0, 0, 0);
            btnStudent.Size = new Size(250, 54);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Student";
            btnStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += button1_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.Image = Properties.Resources.av_timer;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 102);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(250, 54);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(labelRole);
            panelLogo.Controls.Add(labelLastName);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(labelFirstName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 102);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panel1_Paint_1;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI Variable Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelRole.ForeColor = SystemColors.ButtonHighlight;
            labelRole.Location = new Point(107, 52);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(41, 17);
            labelRole.TabIndex = 8;
            labelRole.Text = "NULL";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI Variable Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelLastName.ForeColor = SystemColors.ButtonHighlight;
            labelLastName.Location = new Point(107, 35);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(41, 17);
            labelLastName.TabIndex = 7;
            labelLastName.Text = "NULL";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI Variable Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelFirstName.ForeColor = SystemColors.ButtonHighlight;
            labelFirstName.Location = new Point(107, 18);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(41, 17);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "NULL";
            labelFirstName.Click += labelFirstName_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(264, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 533);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(253, 186, 116);
            ClientSize = new Size(934, 561);
            Controls.Add(panel1);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btnDashboard;
        private Button btnCanteen;
        private Button btnAcademicStaff;
        private Button btnStudent;
        private Button btnAdmin;
        private Button btnParent;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelRole;
    }
}
