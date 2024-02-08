namespace RestaurantMagSystemSecond
{
    partial class UserBankRelatedInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBankRelatedInfoForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            UIdlabel = new Label();
            NewBankBtn = new Button();
            UpdateBankBtn = new Button();
            CreateBankPanel = new Panel();
            CreateBtn = new Button();
            AvailBalanceTF = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BankPassTF = new TextBox();
            PaymentMethodCB = new ComboBox();
            BankUidTF = new TextBox();
            label3 = new Label();
            AddamountPanel = new Panel();
            UpdateBalBtn = new Button();
            AddAmountTF = new TextBox();
            label7 = new Label();
            label11 = new Label();
            BalanceLabel = new Label();
            ReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CreateBankPanel.SuspendLayout();
            AddamountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 1008);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 89);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 225);
            label2.Name = "label2";
            label2.Size = new Size(221, 23);
            label2.TabIndex = 20;
            label2.Text = "User Bank related Tab";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 441);
            label1.Name = "label1";
            label1.Size = new Size(78, 41);
            label1.TabIndex = 22;
            label1.Text = "User ID :";
            // 
            // UIdlabel
            // 
            UIdlabel.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UIdlabel.Location = new Point(330, 441);
            UIdlabel.Name = "UIdlabel";
            UIdlabel.Size = new Size(78, 41);
            UIdlabel.TabIndex = 23;
            UIdlabel.Text = "(UserID)";
            UIdlabel.Click += UIdlabel_Click;
            // 
            // NewBankBtn
            // 
            NewBankBtn.BackColor = SystemColors.Info;
            NewBankBtn.Location = new Point(187, 268);
            NewBankBtn.Margin = new Padding(3, 4, 3, 4);
            NewBankBtn.Name = "NewBankBtn";
            NewBankBtn.Size = new Size(221, 59);
            NewBankBtn.TabIndex = 24;
            NewBankBtn.Text = "Create New Bank Profile";
            NewBankBtn.UseVisualStyleBackColor = false;
            NewBankBtn.Click += NewBankBtn_Click;
            // 
            // UpdateBankBtn
            // 
            UpdateBankBtn.BackColor = SystemColors.Info;
            UpdateBankBtn.Location = new Point(187, 353);
            UpdateBankBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBankBtn.Name = "UpdateBankBtn";
            UpdateBankBtn.Size = new Size(221, 63);
            UpdateBankBtn.TabIndex = 25;
            UpdateBankBtn.Text = "Update Bank Statements";
            UpdateBankBtn.UseVisualStyleBackColor = false;
            UpdateBankBtn.Click += UpdateBankBtn_Click;
            // 
            // CreateBankPanel
            // 
            CreateBankPanel.BackColor = Color.LightSeaGreen;
            CreateBankPanel.Controls.Add(CreateBtn);
            CreateBankPanel.Controls.Add(AvailBalanceTF);
            CreateBankPanel.Controls.Add(label6);
            CreateBankPanel.Controls.Add(label5);
            CreateBankPanel.Controls.Add(label4);
            CreateBankPanel.Controls.Add(BankPassTF);
            CreateBankPanel.Controls.Add(PaymentMethodCB);
            CreateBankPanel.Controls.Add(BankUidTF);
            CreateBankPanel.Controls.Add(label3);
            CreateBankPanel.Location = new Point(569, 247);
            CreateBankPanel.Margin = new Padding(3, 4, 3, 4);
            CreateBankPanel.Name = "CreateBankPanel";
            CreateBankPanel.Size = new Size(596, 419);
            CreateBankPanel.TabIndex = 26;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = SystemColors.Info;
            CreateBtn.Location = new Point(225, 348);
            CreateBtn.Margin = new Padding(3, 4, 3, 4);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(118, 47);
            CreateBtn.TabIndex = 31;
            CreateBtn.Text = "Add Info";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // AvailBalanceTF
            // 
            AvailBalanceTF.BackColor = Color.Cornsilk;
            AvailBalanceTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailBalanceTF.Location = new Point(334, 248);
            AvailBalanceTF.Margin = new Padding(3, 4, 3, 4);
            AvailBalanceTF.Multiline = true;
            AvailBalanceTF.Name = "AvailBalanceTF";
            AvailBalanceTF.Size = new Size(221, 37);
            AvailBalanceTF.TabIndex = 30;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 237);
            label6.Name = "label6";
            label6.Size = new Size(343, 85);
            label6.TabIndex = 29;
            label6.Text = "Enter Recharged amount. Amount will be deducted when you confirm an order :";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 96);
            label5.Name = "label5";
            label5.Size = new Size(266, 69);
            label5.TabIndex = 28;
            label5.Text = "Enter your Payment method(Bkash/Nagad) :";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 181);
            label4.Name = "label4";
            label4.Size = new Size(290, 41);
            label4.TabIndex = 27;
            label4.Text = "Enter your bank account password :";
            // 
            // BankPassTF
            // 
            BankPassTF.BackColor = Color.Cornsilk;
            BankPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BankPassTF.Location = new Point(334, 178);
            BankPassTF.Margin = new Padding(3, 4, 3, 4);
            BankPassTF.Multiline = true;
            BankPassTF.Name = "BankPassTF";
            BankPassTF.Size = new Size(221, 37);
            BankPassTF.TabIndex = 26;
            // 
            // PaymentMethodCB
            // 
            PaymentMethodCB.BackColor = SystemColors.Info;
            PaymentMethodCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentMethodCB.FormattingEnabled = true;
            PaymentMethodCB.Items.AddRange(new object[] { "Bkash", "Nagad" });
            PaymentMethodCB.Location = new Point(334, 113);
            PaymentMethodCB.Margin = new Padding(3, 4, 3, 4);
            PaymentMethodCB.Name = "PaymentMethodCB";
            PaymentMethodCB.Size = new Size(221, 33);
            PaymentMethodCB.TabIndex = 25;
            PaymentMethodCB.Text = "Payment method";
            // 
            // BankUidTF
            // 
            BankUidTF.BackColor = Color.Cornsilk;
            BankUidTF.Enabled = false;
            BankUidTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BankUidTF.Location = new Point(334, 40);
            BankUidTF.Margin = new Padding(3, 4, 3, 4);
            BankUidTF.Multiline = true;
            BankUidTF.Name = "BankUidTF";
            BankUidTF.Size = new Size(221, 35);
            BankUidTF.TabIndex = 24;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 43);
            label3.Name = "label3";
            label3.Size = new Size(231, 41);
            label3.TabIndex = 23;
            label3.Text = "User ID :";
            // 
            // AddamountPanel
            // 
            AddamountPanel.BackColor = Color.CornflowerBlue;
            AddamountPanel.Controls.Add(UpdateBalBtn);
            AddamountPanel.Controls.Add(AddAmountTF);
            AddamountPanel.Controls.Add(label7);
            AddamountPanel.Location = new Point(569, 16);
            AddamountPanel.Margin = new Padding(3, 4, 3, 4);
            AddamountPanel.Name = "AddamountPanel";
            AddamountPanel.Size = new Size(408, 201);
            AddamountPanel.TabIndex = 28;
            // 
            // UpdateBalBtn
            // 
            UpdateBalBtn.BackColor = SystemColors.Info;
            UpdateBalBtn.Location = new Point(146, 113);
            UpdateBalBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBalBtn.Name = "UpdateBalBtn";
            UpdateBalBtn.Size = new Size(118, 47);
            UpdateBalBtn.TabIndex = 32;
            UpdateBalBtn.Text = "Update Balance";
            UpdateBalBtn.UseVisualStyleBackColor = false;
            UpdateBalBtn.Click += UpdateBalBtn_Click;
            // 
            // AddAmountTF
            // 
            AddAmountTF.BackColor = Color.Cornsilk;
            AddAmountTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAmountTF.Location = new Point(237, 49);
            AddAmountTF.Margin = new Padding(3, 4, 3, 4);
            AddAmountTF.Multiline = true;
            AddAmountTF.Name = "AddAmountTF";
            AddAmountTF.Size = new Size(127, 41);
            AddAmountTF.TabIndex = 31;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 24);
            label7.Name = "label7";
            label7.Size = new Size(205, 85);
            label7.TabIndex = 30;
            label7.Text = "Enter an amount you want to add to your existing balance";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(187, 491);
            label11.Name = "label11";
            label11.Size = new Size(142, 41);
            label11.TabIndex = 29;
            label11.Text = "Available Balance :";
            // 
            // BalanceLabel
            // 
            BalanceLabel.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BalanceLabel.Location = new Point(315, 491);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(130, 60);
            BalanceLabel.TabIndex = 30;
            BalanceLabel.Text = "(AvailableBalance)";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Location = new Point(297, 16);
            ReturnBtn.Margin = new Padding(3, 4, 3, 4);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(118, 47);
            ReturnBtn.TabIndex = 32;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // UserBankRelatedInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1288, 1011);
            Controls.Add(ReturnBtn);
            Controls.Add(BalanceLabel);
            Controls.Add(label11);
            Controls.Add(AddamountPanel);
            Controls.Add(CreateBankPanel);
            Controls.Add(UpdateBankBtn);
            Controls.Add(NewBankBtn);
            Controls.Add(UIdlabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserBankRelatedInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserBankRelatedInfoForm";
            Load += UserBankRelatedInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CreateBankPanel.ResumeLayout(false);
            CreateBankPanel.PerformLayout();
            AddamountPanel.ResumeLayout(false);
            AddamountPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label UIdlabel;
        private Button NewBankBtn;
        private Button UpdateBankBtn;
        private Panel CreateBankPanel;
        private Label label3;
        private TextBox BankUidTF;
        private Label label5;
        private Label label4;
        private TextBox BankPassTF;
        private ComboBox PaymentMethodCB;
        private Button CreateBtn;
        private TextBox AvailBalanceTF;
        private Label label6;
        private Panel AddamountPanel;
        private Button UpdateBalBtn;
        private TextBox AddAmountTF;
        private Label label7;
        private Label label11;
        private Label BalanceLabel;
        private Button ReturnBtn;
    }
}