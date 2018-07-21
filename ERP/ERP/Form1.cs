using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{

    public partial class Form1 : Form
    {
        poform po;
        Add_Vendor adv;
        Approve_Vendor apv;
        grnForm grn;
        invoice_form invoice_form;
        addCustomer customer;
        app_cust apCus;
        saleOrder so;
        SaleInvoice salInv;
        public Form1()
        {
            InitializeComponent();
        }
        myConn conn = new myConn();
        Panel[] pnl = new Panel[11];
        Label[] lbl = new Label[11];

        private void Form1_Load(object sender, EventArgs e)
        {
          
            pnl_login.Visible = false;
            this.IsMdiContainer = true;

            MdiClient chld;

            foreach (Control ctrl in this.Controls)
            {
                try
                {
                    chld = (MdiClient)ctrl;

                    chld.BackColor = this.BackColor;
                }

                catch (InvalidCastException exe)

                {

                }
            }

            pnl[0] = panel6;
            pnl[1] = panel7;
            pnl[2] = panel8;
            pnl[3] = panel9;
            pnl[4] = panel10;
            pnl[5] = panel11;
            pnl[6] = panel6;
            pnl[7] = panel4;
            pnl[8] = panel13;
            pnl[9] = panel14;
            pnl[10] = panel15;

            lbl[0] = label6;
            lbl[1] = label7;
            lbl[2] = label8;
            lbl[3] = label9;
            lbl[4] = label10;
            lbl[5] = label11;
            lbl[6] = label5;
            lbl[7] = label12;
            lbl[8] = label13;
            lbl[9] = label14;
            lbl[10] = label15;
        }

    
   

        private void panel5_Click(object sender, EventArgs e)
        {
            this.label16.Hide();
            for (int x=0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;

            }
            panel5.BackColor = Color.DarkCyan;
            this.pnl_login.Visible = true;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel5_Click(sender, e);
        }
        private void panel5_Move(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.LightCyan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            try {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from users where username=@username and password=@password", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    pnl_login.Visible = false;
                    for (int c = 0; c <= 10; c++)
                    {
                        pnl[c].Enabled = true;
                        lbl[c].Enabled = true;
                        panel5.Enabled = false;
                        label5.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login credentials!");
                }

                conn.oleDbConnection1.Close();
            }
            catch(Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel6.BackColor = Color.DarkCyan;
            if (adv == null || adv.Text == "")
            {

                adv = new Add_Vendor();
                adv.MdiParent = this;
                adv.Dock = DockStyle.Fill;
                adv.Show();
            }
            else if (CheckOpened(adv.Text))
            {
                adv.WindowState = FormWindowState.Normal;
                adv.Dock = DockStyle.Fill;
                adv.Show();
                adv.Focus();

            }

        }

        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

            panel6_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel7_Click(sender, e);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel7.BackColor = Color.DarkCyan;
            if (apv == null || apv.Text == "")
            {
                apv = new Approve_Vendor();
                apv.MdiParent = this;
                apv.Dock = DockStyle.Fill;
                apv.Show();
            }
            else if (CheckOpened(apv.Text))
            {
                apv.WindowState = FormWindowState.Normal;
                apv.Dock = DockStyle.Fill;
                apv.Show();
                apv.Focus();

            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel8.BackColor = Color.DarkCyan;
          
            if (po == null || po.Text=="")
            {
                po = new poform();
                po.MdiParent = this;
                po.Dock = DockStyle.Fill;
                po.Show();
            }
            else if(CheckOpened(po.Text))
            {
                po.WindowState = FormWindowState.Normal;
                po.Dock = DockStyle.Fill;
                po.Show();
                po.Focus();

            }

         
        }
        private bool CheckOpened(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel8_Click(sender, e);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel9.BackColor = Color.DarkCyan;
            if (grn == null || grn.Text == "")
            {


                grn = new grnForm();
                grn.MdiParent = this;
                grn.Dock = DockStyle.Fill;
                grn.Show();
            }
            else if (CheckOpened(grn.Text))
            {
                grn.WindowState = FormWindowState.Normal;
                grn.Dock = DockStyle.Fill;
                grn.Show();
                grn.Focus();

            }

        }

        private void panel10_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel10.BackColor = Color.DarkCyan;
            if (invoice_form == null || invoice_form.Text == "")
            {


                invoice_form = new invoice_form();
                invoice_form.MdiParent = this;
                invoice_form.Dock = DockStyle.Fill;
                invoice_form.Show();
            }
            else if (CheckOpened(invoice_form.Text))
            {
                invoice_form.WindowState = FormWindowState.Normal;
                invoice_form.Dock = DockStyle.Fill;
                invoice_form.Show();
                invoice_form.Focus();

            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel4.BackColor = Color.DarkCyan;

            if (customer == null || customer.Text == "")
            {


                customer = new addCustomer();
                customer.MdiParent = this;
                customer.Dock = DockStyle.Fill;
                customer.Show();
            }
            else if (CheckOpened(customer.Text))
            {
                customer.WindowState = FormWindowState.Normal;
                customer.Dock = DockStyle.Fill;
                customer.Show();
                customer.Focus();

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel10_Click(sender, e);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel13.BackColor = Color.DarkCyan;

            if (apCus == null || apCus.Text == "")
            {


                apCus = new app_cust();
                apCus.MdiParent = this;
                apCus.Dock = DockStyle.Fill;
                apCus.Show();
            }
            else if (CheckOpened(apCus.Text))
            {
                apCus.WindowState = FormWindowState.Normal;
                apCus.Dock = DockStyle.Fill;
                apCus.Show();
                apCus.Focus();

            }

        }

        private void label13_Click(object sender, EventArgs e)
        {
                panel13_Click(sender, e);
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel14.BackColor = Color.DarkCyan;

            if (so == null || so.Text == "")
            {


                so = new saleOrder();
                so.MdiParent = this;
                so.Dock = DockStyle.Fill;
                so.Show();
            }
            else if (CheckOpened(so.Text))
            {
                so.WindowState = FormWindowState.Normal;
                so.Dock = DockStyle.Fill;
                so.Show();
                so.Focus();

            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
            panel14_Click(sender, e);
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < pnl.Length; x++)
            {
                pnl[x].BackColor = Color.Gray;
            }
            panel15.BackColor = Color.DarkCyan;

            if (salInv == null || salInv.Text == "")
            {


                salInv = new SaleInvoice();
                salInv.MdiParent = this;
                salInv.Dock = DockStyle.Fill;
                salInv.Show();
            }
            else if (CheckOpened(salInv.Text))
            {
                salInv.WindowState = FormWindowState.Normal;
                salInv.Dock = DockStyle.Fill;
                salInv.Show();
                salInv.Focus();

            }

        }

        private void label15_Click(object sender, EventArgs e)
        {
            panel15_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        
    }

        private void label11_Click(object sender, EventArgs e)
        {
            panel11_Click(sender, e);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_login.Hide();
        }
    }
}
