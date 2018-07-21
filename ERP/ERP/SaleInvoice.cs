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
    public partial class SaleInvoice : Form
    {

        myConn conn = new myConn();
        public SaleInvoice()
        {
            InitializeComponent();
        }

        private void SaleInvoice_Load(object sender, EventArgs e)
        {

            int CID = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(invoiceid) from saleinvoice", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                CID = Convert.ToInt32(dr1[0]);
                CID++;
            }
            conn.oleDbConnection1.Close();
            this.tbx_InvNum.Text = "SalInv" + "-" + CID + "-" + System.DateTime.Today.Year;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select soid from so where status='Open'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx_SOID.Items.Add(dr["soid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void cbx_SOID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from so where soid=@soid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", cbx_SOID.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbx_soDate.Text = dr["sodate"].ToString();
                tbx_dDate.Text = dr["ddate"].ToString();
                tbx_customer.Text = dr["cname"].ToString();
                tbx_cCP.Text = dr["ccontectperson"].ToString();
                tbx_cCPh.Text = dr["ccpph"].ToString();
                tbx_amount.Text = dr["totalamount"].ToString();
                tbx_CID.Text = dr["cid"].ToString();

            }

            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from soProducts where soid = @soid", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@soid", cbx_SOID.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into saleinvoice(invoiceid, customerID, customerName, contectperson, cpph, dcdate, cdate, amountreceivable)values(@invoiceid, @customerID, @customerName, @contectperson, @cpph, @dcdate, @cdate, @amountreceivable)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@invoiceid", tbx_InvNum.Text);
                cmd.Parameters.AddWithValue("@customerID", tbx_CID.Text);
                cmd.Parameters.AddWithValue("@customername", tbx_customer.Text);
                cmd.Parameters.AddWithValue("@contectperson", tbx_cCP.Text);
                cmd.Parameters.AddWithValue("@cpph", tbx_cCPh.Text);
                cmd.Parameters.AddWithValue("@dcdate", dateTimePicker2);
                cmd.Parameters.AddWithValue("@cdate", dateTimePicker1);
                cmd.Parameters.AddWithValue("@amountpayable", tbx_amount.Text);
                cmd.ExecuteNonQuery();

            }
            catch(Exception)
            {
                MessageBox.Show("Plese insert values correctly!");
            }

                OleDbCommand cmd3 = new OleDbCommand("update so set status='close' where soid= @soid", conn.oleDbConnection1);
                cmd3.Parameters.AddWithValue("@soid", cbx_SOID.Text);
                cmd3.ExecuteNonQuery();

                conn.oleDbConnection1.Close();
            
            lbl_msg.Text = "Invoice Generated Successfully!";

        }
    }
}
