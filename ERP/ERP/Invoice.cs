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
    public partial class invoice_form : Form
    {
        myConn conn = new myConn();
        public invoice_form()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from grn where status = 'Close'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cbx_poID.Items.Add(dr["poid"].ToString());
            }
            conn.oleDbConnection1.Close();

            int CID = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(invoiceid) from invoice", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                CID = Convert.ToInt32(dr1[0]);
                CID++;
            }
            conn.oleDbConnection1.Close();
            this.textBox1.Text = "INV" + "-" + CID + "-" + System.DateTime.Today.Year;

            
        }

        private void cbx_poID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from po where poid=@pid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", cbx_poID.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbx_poDate.Text = dr["podate"].ToString();
                tbx_dDate.Text = dr["ddate"].ToString();
                tbx_vendor.Text = dr["vname"].ToString();
                tbx_vCP.Text = dr["vcontectperson"].ToString();
                tbx_vCph.Text = dr["vcpph"].ToString();
                tbx_amount.Text = dr["totalamount"].ToString();
                tbx_VID.Text = dr["vid"].ToString();



            }
            OleDbCommand cmd2 = new OleDbCommand("select * from grn where poid=@poid ", conn.oleDbConnection1);
            cmd2.Parameters.AddWithValue("@poid", cbx_poID.Text);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                tbx_grnDate.Text = dr2["grdate"].ToString();
                tbx_grnid.Text = dr2["grnid"].ToString();



            }

            conn.oleDbConnection1.Close();

            ;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from POProducts where poid = @poid", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@poid", cbx_poID.Text);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr1);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into invoice(invoiceid, vendorid, vendorname, contectperson, cpph, dcdate, grndate, cdate, amountpayable, grnid)values(@invoiceid, @vendorid, @vendorname, @contectperson, @cpph, @dcdate, @grndate, @cdate, @amountpayable, @grnid)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@invoiceid", textBox1.Text);
                cmd.Parameters.AddWithValue("@vendorid", tbx_VID.Text);
                cmd.Parameters.AddWithValue("@vendorname", tbx_vendor.Text);
                cmd.Parameters.AddWithValue("@contectperson", tbx_vCP.Text);
                cmd.Parameters.AddWithValue("@cpph", tbx_vCph.Text);
                cmd.Parameters.AddWithValue("@dcdate", dateTimePicker2);
                cmd.Parameters.AddWithValue("@grndate", tbx_grnDate.Text);
                cmd.Parameters.AddWithValue("@cdate", dateTimePicker1);
                cmd.Parameters.AddWithValue("@amountpayable", tbx_amount.Text);
                cmd.Parameters.AddWithValue("grnid", tbx_grnid.Text);
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }

            OleDbCommand cmd2 = new OleDbCommand("update grn set status='close' where poid = @poid", conn.oleDbConnection1);
            cmd2.Parameters.AddWithValue("@poid", cbx_poID.Text);
            cmd2.ExecuteNonQuery();
            OleDbCommand cmd3 = new OleDbCommand("update po set status='close' where poid = @poid", conn.oleDbConnection1);
            cmd3.Parameters.AddWithValue("@poid", cbx_poID.Text);
            cmd3.ExecuteNonQuery();

            conn.oleDbConnection1.Close();
            lbl_msg.Text = "Invoice Generated Successfully!";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
