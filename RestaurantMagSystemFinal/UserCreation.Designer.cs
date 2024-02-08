namespace RestaurantMagSystemSecond
{
    partial class UserCreation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreation));
            panel1 = new Panel();
            UNameTF = new TextBox();
            label1 = new Label();
            UPassTF = new TextBox();
            UMnoTF = new TextBox();
            UCityCB = new ComboBox();
            RoleCB = new ComboBox();
            UStatusCB = new ComboBox();
            ULocTF = new TextBox();
            SignUpBtn = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(2, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 748);
            panel1.TabIndex = 0;
            // 
            // UNameTF
            // 
            UNameTF.BackColor = Color.Cornsilk;
            UNameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UNameTF.Location = new Point(456, 119);
            UNameTF.Margin = new Padding(3, 4, 3, 4);
            UNameTF.Multiline = true;
            UNameTF.Name = "UNameTF";
            UNameTF.PlaceholderText = "Username";
            UNameTF.Size = new Size(221, 45);
            UNameTF.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(427, 53);
            label1.Name = "label1";
            label1.Size = new Size(338, 25);
            label1.TabIndex = 6;
            label1.Text = "Please fill out all the information correctly";
            // 
            // UPassTF
            // 
            UPassTF.BackColor = Color.Cornsilk;
            UPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UPassTF.Location = new Point(456, 200);
            UPassTF.Margin = new Padding(3, 4, 3, 4);
            UPassTF.Multiline = true;
            UPassTF.Name = "UPassTF";
            UPassTF.PlaceholderText = "password";
            UPassTF.Size = new Size(221, 45);
            UPassTF.TabIndex = 7;
            // 
            // UMnoTF
            // 
            UMnoTF.BackColor = Color.Cornsilk;
            UMnoTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UMnoTF.Location = new Point(456, 284);
            UMnoTF.Margin = new Padding(3, 4, 3, 4);
            UMnoTF.Multiline = true;
            UMnoTF.Name = "UMnoTF";
            UMnoTF.PlaceholderText = "Mobile number";
            UMnoTF.Size = new Size(221, 45);
            UMnoTF.TabIndex = 8;
            // 
            // UCityCB
            // 
            UCityCB.BackColor = SystemColors.Info;
            UCityCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UCityCB.FormattingEnabled = true;
            UCityCB.Items.AddRange(new object[] { "Dhaka", "Rajshahi", "Chittagong", "Gazipur", "Narayanganj", "Sylhet", "Bogura" });
            UCityCB.Location = new Point(456, 371);
            UCityCB.Margin = new Padding(3, 4, 3, 4);
            UCityCB.Name = "UCityCB";
            UCityCB.Size = new Size(221, 33);
            UCityCB.TabIndex = 9;
            UCityCB.Text = "City";
            // 
            // RoleCB
            // 
            RoleCB.BackColor = SystemColors.Info;
            RoleCB.Enabled = false;
            RoleCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCB.FormattingEnabled = true;
            RoleCB.Items.AddRange(new object[] { "User", "Admin", "Driver" });
            RoleCB.Location = new Point(456, 444);
            RoleCB.Margin = new Padding(3, 4, 3, 4);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(221, 33);
            RoleCB.TabIndex = 10;
            RoleCB.Text = "User";
            // 
            // UStatusCB
            // 
            UStatusCB.BackColor = SystemColors.Info;
            UStatusCB.Enabled = false;
            UStatusCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UStatusCB.FormattingEnabled = true;
            UStatusCB.Items.AddRange(new object[] { "Actived", "Deactivated" });
            UStatusCB.Location = new Point(456, 512);
            UStatusCB.Margin = new Padding(3, 4, 3, 4);
            UStatusCB.Name = "UStatusCB";
            UStatusCB.Size = new Size(221, 33);
            UStatusCB.TabIndex = 11;
            UStatusCB.Text = "Deactivated";
            // 
            // ULocTF
            // 
            ULocTF.BackColor = Color.Cornsilk;
            ULocTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ULocTF.Location = new Point(456, 577);
            ULocTF.Margin = new Padding(3, 4, 3, 4);
            ULocTF.Multiline = true;
            ULocTF.Name = "ULocTF";
            ULocTF.PlaceholderText = "Location";
            ULocTF.Size = new Size(221, 67);
            ULocTF.TabIndex = 12;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = SystemColors.Info;
            SignUpBtn.Location = new Point(514, 671);
            SignUpBtn.Margin = new Padding(3, 4, 3, 4);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(101, 43);
            SignUpBtn.TabIndex = 13;
            SignUpBtn.Text = "SignUp";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, 53);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 221);
            label2.Name = "label2";
            label2.Size = new Size(181, 23);
            label2.TabIndex = 15;
            label2.Text = "User Creation Tab";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Location = new Point(777, 37);
            ReturnBtn.Margin = new Padding(3, 4, 3, 4);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(101, 43);
            ReturnBtn.TabIndex = 16;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // UserCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 745);
            Controls.Add(ReturnBtn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(SignUpBtn);
            Controls.Add(ULocTF);
            Controls.Add(UStatusCB);
            Controls.Add(RoleCB);
            Controls.Add(UCityCB);
            Controls.Add(UMnoTF);
            Controls.Add(UPassTF);
            Controls.Add(label1);
            Controls.Add(UNameTF);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserCreation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox UNameTF;
        private Label label1;
        private TextBox UPassTF;
        private TextBox UMnoTF;
        private ComboBox UCityCB;
        private ComboBox RoleCB;
        private ComboBox UStatusCB;
        private TextBox ULocTF;
        private Button SignUpBtn;
        private PictureBox pictureBox1;
        private Label label2;
        private Button ReturnBtn;
    }
}