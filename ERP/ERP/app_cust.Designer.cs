namespace ERP
{
    partial class app_cust
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
            this.lbl_msg = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_CID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_CreditLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_ph1 = new System.Windows.Forms.TextBox();
            this.tbx_group = new System.Windows.Forms.TextBox();
            this.tbx_ph2 = new System.Windows.Forms.TextBox();
            this.tbx_CuName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_city = new System.Windows.Forms.TextBox();
            this.Disapprove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_CPEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_CPPh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_CPName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Approve = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_msg.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_msg.Location = new System.Drawing.Point(372, 309);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 19);
            this.lbl_msg.TabIndex = 115;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.cbx_CID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbx_CreditLimit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbx_address);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbx_ph1);
            this.groupBox2.Controls.Add(this.tbx_group);
            this.groupBox2.Controls.Add(this.tbx_ph2);
            this.groupBox2.Controls.Add(this.tbx_CuName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbx_city);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(20, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 345);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cutomer Details";
            // 
            // cbx_CID
            // 
            this.cbx_CID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_CID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_CID.FormattingEnabled = true;
            this.cbx_CID.Location = new System.Drawing.Point(127, 24);
            this.cbx_CID.Name = "cbx_CID";
            this.cbx_CID.Size = new System.Drawing.Size(186, 25);
            this.cbx_CID.TabIndex = 6;
            this.cbx_CID.SelectedIndexChanged += new System.EventHandler(this.cbx_CID_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(40, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 88;
            this.label10.Text = "Credit Limit";
            // 
            // tbx_CreditLimit
            // 
            this.tbx_CreditLimit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_CreditLimit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_CreditLimit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_CreditLimit.Location = new System.Drawing.Point(128, 300);
            this.tbx_CreditLimit.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_CreditLimit.Name = "tbx_CreditLimit";
            this.tbx_CreditLimit.ReadOnly = true;
            this.tbx_CreditLimit.Size = new System.Drawing.Size(186, 25);
            this.tbx_CreditLimit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(72, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 87;
            this.label3.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Customer ID";
            // 
            // tbx_address
            // 
            this.tbx_address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_address.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_address.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_address.Location = new System.Drawing.Point(128, 102);
            this.tbx_address.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.ReadOnly = true;
            this.tbx_address.Size = new System.Drawing.Size(186, 25);
            this.tbx_address.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(62, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 85;
            this.label7.Text = "Address";
            // 
            // tbx_ph1
            // 
            this.tbx_ph1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_ph1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_ph1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_ph1.Location = new System.Drawing.Point(128, 184);
            this.tbx_ph1.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ph1.Name = "tbx_ph1";
            this.tbx_ph1.ReadOnly = true;
            this.tbx_ph1.Size = new System.Drawing.Size(186, 25);
            this.tbx_ph1.TabIndex = 4;
            // 
            // tbx_group
            // 
            this.tbx_group.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_group.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_group.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_group.Location = new System.Drawing.Point(127, 264);
            this.tbx_group.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_group.Name = "tbx_group";
            this.tbx_group.ReadOnly = true;
            this.tbx_group.Size = new System.Drawing.Size(186, 25);
            this.tbx_group.TabIndex = 0;
            // 
            // tbx_ph2
            // 
            this.tbx_ph2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_ph2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_ph2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_ph2.Location = new System.Drawing.Point(128, 225);
            this.tbx_ph2.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ph2.Name = "tbx_ph2";
            this.tbx_ph2.ReadOnly = true;
            this.tbx_ph2.Size = new System.Drawing.Size(186, 25);
            this.tbx_ph2.TabIndex = 5;
            // 
            // tbx_CuName
            // 
            this.tbx_CuName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_CuName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_CuName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_CuName.Location = new System.Drawing.Point(128, 61);
            this.tbx_CuName.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_CuName.Name = "tbx_CuName";
            this.tbx_CuName.ReadOnly = true;
            this.tbx_CuName.Size = new System.Drawing.Size(186, 25);
            this.tbx_CuName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(60, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 82;
            this.label6.Text = "Phone 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(87, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(60, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 81;
            this.label5.Text = "Phone 1";
            // 
            // tbx_city
            // 
            this.tbx_city.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_city.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_city.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_city.Location = new System.Drawing.Point(128, 143);
            this.tbx_city.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_city.Name = "tbx_city";
            this.tbx_city.ReadOnly = true;
            this.tbx_city.Size = new System.Drawing.Size(186, 25);
            this.tbx_city.TabIndex = 3;
            // 
            // Disapprove
            // 
            this.Disapprove.BackColor = System.Drawing.Color.Crimson;
            this.Disapprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disapprove.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Disapprove.ForeColor = System.Drawing.Color.White;
            this.Disapprove.Location = new System.Drawing.Point(376, 250);
            this.Disapprove.Margin = new System.Windows.Forms.Padding(4);
            this.Disapprove.Name = "Disapprove";
            this.Disapprove.Size = new System.Drawing.Size(143, 42);
            this.Disapprove.TabIndex = 113;
            this.Disapprove.Text = "Disapprove";
            this.Disapprove.UseVisualStyleBackColor = false;
            this.Disapprove.Click += new System.EventHandler(this.Disapprove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(4, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 30);
            this.label9.TabIndex = 114;
            this.label9.Text = "Customer -Approve";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tbx_CPEmail);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbx_CPPh);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbx_CPName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(376, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 154);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Person";
            // 
            // tbx_CPEmail
            // 
            this.tbx_CPEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_CPEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_CPEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_CPEmail.Location = new System.Drawing.Point(80, 100);
            this.tbx_CPEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_CPEmail.Name = "tbx_CPEmail";
            this.tbx_CPEmail.ReadOnly = true;
            this.tbx_CPEmail.Size = new System.Drawing.Size(186, 25);
            this.tbx_CPEmail.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(21, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 93;
            this.label12.Text = "E-mail";
            // 
            // tbx_CPPh
            // 
            this.tbx_CPPh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_CPPh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_CPPh.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_CPPh.Location = new System.Drawing.Point(80, 63);
            this.tbx_CPPh.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_CPPh.Name = "tbx_CPPh";
            this.tbx_CPPh.ReadOnly = true;
            this.tbx_CPPh.Size = new System.Drawing.Size(186, 25);
            this.tbx_CPPh.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(21, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 91;
            this.label11.Text = "Phone";
            // 
            // tbx_CPName
            // 
            this.tbx_CPName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_CPName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_CPName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_CPName.Location = new System.Drawing.Point(80, 30);
            this.tbx_CPName.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_CPName.Name = "tbx_CPName";
            this.tbx_CPName.ReadOnly = true;
            this.tbx_CPName.Size = new System.Drawing.Size(186, 25);
            this.tbx_CPName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(24, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 87;
            this.label8.Text = "Name";
            // 
            // Approve
            // 
            this.Approve.BackColor = System.Drawing.Color.DarkCyan;
            this.Approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Approve.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Approve.ForeColor = System.Drawing.Color.White;
            this.Approve.Location = new System.Drawing.Point(539, 250);
            this.Approve.Margin = new System.Windows.Forms.Padding(4);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(143, 42);
            this.Approve.TabIndex = 112;
            this.Approve.Text = "Approve";
            this.Approve.UseVisualStyleBackColor = false;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // app_cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(738, 417);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Disapprove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Approve);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "app_cust";
            this.Text = "app_cust";
            this.Load += new System.EventHandler(this.app_cust_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_CID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_CreditLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_ph1;
        private System.Windows.Forms.TextBox tbx_group;
        private System.Windows.Forms.TextBox tbx_ph2;
        private System.Windows.Forms.TextBox tbx_CuName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_city;
        private System.Windows.Forms.Button Disapprove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_CPEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_CPPh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_CPName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Approve;
    }
}