namespace RestaurantMagSystemSecond
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            panel1 = new Panel();
            PaymentProcessBtn = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            PaymentUIDTF = new TextBox();
            label1 = new Label();
            PaymentTotalAmountTF = new TextBox();
            label3 = new Label();
            PaymentMethodCB = new ComboBox();
            ConfirmPaymentBtn = new Button();
            PaymentbankPass = new TextBox();
            ReturnBtn = new Button();
            SuffBalanceLbel = new Label();
            InsufficientbalLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(PaymentProcessBtn);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 781);
            panel1.TabIndex = 0;
            // 
            // PaymentProcessBtn
            // 
            PaymentProcessBtn.BackColor = SystemColors.Info;
            PaymentProcessBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentProcessBtn.Location = new Point(14, 73);
            PaymentProcessBtn.Margin = new Padding(3, 4, 3, 4);
            PaymentProcessBtn.Name = "PaymentProcessBtn";
            PaymentProcessBtn.Size = new Size(193, 67);
            PaymentProcessBtn.TabIndex = 28;
            PaymentProcessBtn.Text = "Manage payment process";
            PaymentProcessBtn.UseVisualStyleBackColor = false;
            PaymentProcessBtn.Click += PaymentProcessBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(446, 95);
            label6.Name = "label6";
            label6.Size = new Size(338, 85);
            label6.TabIndex = 18;
            label6.Text = "Insert all the information below to complete your payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(272, 207);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 19;
            label2.Text = "User Payment Tab";
            // 
            // PaymentUIDTF
            // 
            PaymentUIDTF.BackColor = Color.Cornsilk;
            PaymentUIDTF.Enabled = false;
            PaymentUIDTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentUIDTF.Location = new Point(446, 249);
            PaymentUIDTF.Margin = new Padding(3, 4, 3, 4);
            PaymentUIDTF.Multiline = true;
            PaymentUIDTF.Name = "PaymentUIDTF";
            PaymentUIDTF.Size = new Size(278, 45);
            PaymentUIDTF.TabIndex = 20;
            PaymentUIDTF.TextChanged += PaymentUIDTF_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 253);
            label1.Name = "label1";
            label1.Size = new Size(66, 41);
            label1.TabIndex = 21;
            label1.Text = "User ID";
            // 
            // PaymentTotalAmountTF
            // 
            PaymentTotalAmountTF.BackColor = Color.Cornsilk;
            PaymentTotalAmountTF.Enabled = false;
            PaymentTotalAmountTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentTotalAmountTF.Location = new Point(446, 324);
            PaymentTotalAmountTF.Margin = new Padding(3, 4, 3, 4);
            PaymentTotalAmountTF.Multiline = true;
            PaymentTotalAmountTF.Name = "PaymentTotalAmountTF";
            PaymentTotalAmountTF.Size = new Size(278, 45);
            PaymentTotalAmountTF.TabIndex = 22;
            PaymentTotalAmountTF.TextChanged += PaymentTotalAmountTF_TextChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(248, 328);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 23;
            label3.Text = "Total amount to be paid";
            // 
            // PaymentMethodCB
            // 
            PaymentMethodCB.BackColor = SystemColors.Info;
            PaymentMethodCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentMethodCB.FormattingEnabled = true;
            PaymentMethodCB.Items.AddRange(new object[] { "Bkash", "Nagad" });
            PaymentMethodCB.Location = new Point(263, 493);
            PaymentMethodCB.Margin = new Padding(3, 4, 3, 4);
            PaymentMethodCB.Name = "PaymentMethodCB";
            PaymentMethodCB.Size = new Size(221, 33);
            PaymentMethodCB.TabIndex = 24;
            PaymentMethodCB.Text = "Payment method";
            // 
            // ConfirmPaymentBtn
            // 
            ConfirmPaymentBtn.BackColor = SystemColors.Info;
            ConfirmPaymentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmPaymentBtn.Location = new Point(467, 565);
            ConfirmPaymentBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmPaymentBtn.Name = "ConfirmPaymentBtn";
            ConfirmPaymentBtn.Size = new Size(160, 47);
            ConfirmPaymentBtn.TabIndex = 28;
            ConfirmPaymentBtn.Text = "Confirm Payment";
            ConfirmPaymentBtn.UseVisualStyleBackColor = false;
            ConfirmPaymentBtn.Click += ConfirmPaymentBtn_Click;
            // 
            // PaymentbankPass
            // 
            PaymentbankPass.BackColor = Color.Cornsilk;
            PaymentbankPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentbankPass.Location = new Point(503, 493);
            PaymentbankPass.Margin = new Padding(3, 4, 3, 4);
            PaymentbankPass.Multiline = true;
            PaymentbankPass.Name = "PaymentbankPass";
            PaymentbankPass.PlaceholderText = "Bank password";
            PaymentbankPass.Size = new Size(221, 36);
            PaymentbankPass.TabIndex = 29;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnBtn.Location = new Point(587, 37);
            ReturnBtn.Margin = new Padding(3, 4, 3, 4);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(197, 47);
            ReturnBtn.TabIndex = 30;
            ReturnBtn.Text = "Return to menupage";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // SuffBalanceLbel
            // 
            SuffBalanceLbel.AutoSize = true;
            SuffBalanceLbel.Location = new Point(407, 397);
            SuffBalanceLbel.Name = "SuffBalanceLbel";
            SuffBalanceLbel.Size = new Size(200, 20);
            SuffBalanceLbel.TabIndex = 31;
            SuffBalanceLbel.Text = "(If there is sufficient balance)";
            // 
            // InsufficientbalLabel
            // 
            InsufficientbalLabel.AutoSize = true;
            InsufficientbalLabel.Location = new Point(340, 445);
            InsufficientbalLabel.Name = "InsufficientbalLabel";
            InsufficientbalLabel.Size = new Size(212, 20);
            InsufficientbalLabel.TabIndex = 32;
            InsufficientbalLabel.Text = "(If there is insufficient balance)";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(940, 781);
            Controls.Add(InsufficientbalLabel);
            Controls.Add(SuffBalanceLbel);
            Controls.Add(ReturnBtn);
            Controls.Add(PaymentbankPass);
            Controls.Add(ConfirmPaymentBtn);
            Controls.Add(PaymentMethodCB);
            Controls.Add(label3);
            Controls.Add(PaymentTotalAmountTF);
            Controls.Add(label1);
            Controls.Add(PaymentUIDTF);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label2;
        private TextBox PaymentUIDTF;
        private Label label1;
        private TextBox PaymentTotalAmountTF;
        private Label label3;
        private ComboBox PaymentMethodCB;
        private Button ConfirmPaymentBtn;
        private TextBox PaymentbankPass;
        private Button PaymentProcessBtn;
        private Button ReturnBtn;
        private Label SuffBalanceLbel;
        private Label InsufficientbalLabel;
    }
}