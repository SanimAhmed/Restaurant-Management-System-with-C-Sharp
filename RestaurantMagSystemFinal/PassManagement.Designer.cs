namespace RestaurantMagSystemSecond
{
    partial class PassManagement
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
            label1 = new Label();
            NameTF = new TextBox();
            EnterBtn = new Button();
            ConfirmBtn = new Button();
            NewpassTF = new TextBox();
            label2 = new Label();
            ReturnBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 73);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 4;
            label1.Text = "Please enter your registered name ";
            // 
            // NameTF
            // 
            NameTF.BackColor = Color.Cornsilk;
            NameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTF.Location = new Point(450, 70);
            NameTF.Margin = new Padding(3, 4, 3, 4);
            NameTF.Multiline = true;
            NameTF.Name = "NameTF";
            NameTF.PlaceholderText = " Name";
            NameTF.Size = new Size(221, 47);
            NameTF.TabIndex = 5;
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = SystemColors.Info;
            EnterBtn.Location = new Point(508, 138);
            EnterBtn.Margin = new Padding(3, 4, 3, 4);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(101, 43);
            EnterBtn.TabIndex = 6;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = SystemColors.Info;
            ConfirmBtn.Location = new Point(508, 344);
            ConfirmBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(101, 43);
            ConfirmBtn.TabIndex = 7;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // NewpassTF
            // 
            NewpassTF.BackColor = Color.Cornsilk;
            NewpassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewpassTF.Location = new Point(450, 265);
            NewpassTF.Margin = new Padding(3, 4, 3, 4);
            NewpassTF.Multiline = true;
            NewpassTF.Name = "NewpassTF";
            NewpassTF.PasswordChar = '*';
            NewpassTF.PlaceholderText = "password";
            NewpassTF.Size = new Size(221, 47);
            NewpassTF.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 268);
            label2.Name = "label2";
            label2.Size = new Size(265, 25);
            label2.TabIndex = 9;
            label2.Text = "Please enter your new password";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Location = new Point(783, 37);
            ReturnBtn.Margin = new Padding(3, 4, 3, 4);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(101, 43);
            ReturnBtn.TabIndex = 10;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // PassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ReturnBtn);
            Controls.Add(label2);
            Controls.Add(NewpassTF);
            Controls.Add(ConfirmBtn);
            Controls.Add(EnterBtn);
            Controls.Add(NameTF);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PassManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PassManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTF;
        private Button EnterBtn;
        private Button ConfirmBtn;
        private TextBox NewpassTF;
        private Label label2;
        private Button ReturnBtn;
    }
}