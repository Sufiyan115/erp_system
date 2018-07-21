namespace ERP
{
    partial class invoice_form
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
            this.tbx_dDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_poDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_poID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_vendor = new System.Windows.Forms.TextBox();
            this.tbx_vCph = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cpph = new System.Windows.Forms.Label();
            this.tbx_vCP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbx_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.tbx_VID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_grnDate = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbx_grnid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_dDate
            // 
            this.tbx_dDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_dDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_dDate.Location = new System.Drawing.Point(105, 102);
            this.tbx_dDate.Name = "tbx_dDate";
            this.tbx_dDate.ReadOnly = true;
            this.tbx_dDate.Size = new System.Drawing.Size(200, 25);
            this.tbx_dDate.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 103;
            this.label4.Text = "DEL. DATE";
            // 
            // tbx_poDate
            // 
            this.tbx_poDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_poDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_poDate.Location = new System.Drawing.Point(104, 63);
            this.tbx_poDate.Name = "tbx_poDate";
            this.tbx_poDate.ReadOnly = true;
            this.tbx_poDate.Size = new System.Drawing.Size(200, 25);
            this.tbx_poDate.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(19, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 101;
            this.label10.Text = "PO DATE";
            // 
            // cbx_poID
            // 
            this.cbx_poID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_poID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_poID.FormattingEnabled = true;
            this.cbx_poID.Location = new System.Drawing.Point(105, 27);
            this.cbx_poID.Name = "cbx_poID";
            this.cbx_poID.Size = new System.Drawing.Size(200, 25);
            this.cbx_poID.TabIndex = 99;
            this.cbx_poID.SelectedIndexChanged += new System.EventHandler(this.cbx_poID_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.tbx_dDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbx_poDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbx_poID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(351, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 139);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PO Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(19, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "PO ID";
            // 
            // tbx_vendor
            // 
            this.tbx_vendor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_vendor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_vendor.Location = new System.Drawing.Point(101, 65);
            this.tbx_vendor.Name = "tbx_vendor";
            this.tbx_vendor.ReadOnly = true;
            this.tbx_vendor.Size = new System.Drawing.Size(200, 25);
            this.tbx_vendor.TabIndex = 105;
            // 
            // tbx_vCph
            // 
            this.tbx_vCph.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_vCph.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_vCph.Location = new System.Drawing.Point(102, 139);
            this.tbx_vCph.Name = "tbx_vCph";
            this.tbx_vCph.ReadOnly = true;
            this.tbx_vCph.Size = new System.Drawing.Size(200, 25);
            this.tbx_vCph.TabIndex = 104;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(18, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 139);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invlice #";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(101, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(101, 104);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "D. DATE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(13, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 30);
            this.label9.TabIndex = 110;
            this.label9.Text = "Invoice - Purchase";
            // 
            // lbl_cpph
            // 
            this.lbl_cpph.AutoSize = true;
            this.lbl_cpph.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpph.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_cpph.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_cpph.Location = new System.Drawing.Point(20, 139);
            this.lbl_cpph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cpph.Name = "lbl_cpph";
            this.lbl_cpph.Size = new System.Drawing.Size(56, 19);
            this.lbl_cpph.TabIndex = 103;
            this.lbl_cpph.Text = "CP PH#";
            // 
            // tbx_vCP
            // 
            this.tbx_vCP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_vCP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_vCP.Location = new System.Drawing.Point(102, 100);
            this.tbx_vCP.Name = "tbx_vCP";
            this.tbx_vCP.ReadOnly = true;
            this.tbx_vCP.Size = new System.Drawing.Size(200, 25);
            this.tbx_vCP.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(19, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 98;
            this.label6.Text = "VENDOR";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.tbx_VID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbx_vendor);
            this.groupBox3.Controls.Add(this.tbx_vCph);
            this.groupBox3.Controls.Add(this.lbl_cpph);
            this.groupBox3.Controls.Add(this.tbx_vCP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox3.Location = new System.Drawing.Point(687, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 175);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendor Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(18, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 27);
            this.panel1.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(299, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 101;
            this.label7.Text = "ITEMS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 121);
            this.dataGridView1.TabIndex = 113;
            // 
            // tbx_amount
            // 
            this.tbx_amount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_amount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_amount.Location = new System.Drawing.Point(755, 258);
            this.tbx_amount.Name = "tbx_amount";
            this.tbx_amount.ReadOnly = true;
            this.tbx_amount.Size = new System.Drawing.Size(200, 25);
            this.tbx_amount.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(800, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 19);
            this.label11.TabIndex = 106;
            this.label11.Text = "TOTAL AMOUNT";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(788, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 31);
            this.button2.TabIndex = 115;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_msg.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_msg.Location = new System.Drawing.Point(736, 319);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 19);
            this.lbl_msg.TabIndex = 116;
            // 
            // tbx_VID
            // 
            this.tbx_VID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_VID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_VID.Location = new System.Drawing.Point(101, 31);
            this.tbx_VID.Name = "tbx_VID";
            this.tbx_VID.ReadOnly = true;
            this.tbx_VID.Size = new System.Drawing.Size(200, 25);
            this.tbx_VID.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(19, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 19);
            this.label12.TabIndex = 106;
            this.label12.Text = "V. ID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(346, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "GRN Date:";
            // 
            // tbx_grnDate
            // 
            this.tbx_grnDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_grnDate.Location = new System.Drawing.Point(439, 22);
            this.tbx_grnDate.Name = "tbx_grnDate";
            this.tbx_grnDate.ReadOnly = true;
            this.tbx_grnDate.Size = new System.Drawing.Size(199, 25);
            this.tbx_grnDate.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.tbx_grnid);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbx_grnDate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox4.Location = new System.Drawing.Point(18, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(653, 56);
            this.groupBox4.TabIndex = 110;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GRN Information";
            // 
            // tbx_grnid
            // 
            this.tbx_grnid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbx_grnid.Location = new System.Drawing.Point(103, 24);
            this.tbx_grnid.Name = "tbx_grnid";
            this.tbx_grnid.ReadOnly = true;
            this.tbx_grnid.Size = new System.Drawing.Size(199, 25);
            this.tbx_grnid.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(10, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 19);
            this.label14.TabIndex = 18;
            this.label14.Text = "GRN ID:";
            // 
            // invoice_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1027, 457);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbx_amount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoice_form";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_dDate;
        private System.Windows.Forms.TextBox tbx_poDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_poID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_vendor;
        private System.Windows.Forms.TextBox tbx_vCph;
        private System.Windows.Forms.Label lbl_cpph;
        private System.Windows.Forms.TextBox tbx_vCP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbx_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.TextBox tbx_VID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_grnDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbx_grnid;
        private System.Windows.Forms.Label label14;
    }
}