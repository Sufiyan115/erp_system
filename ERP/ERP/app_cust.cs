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
    
    public partial class app_cust : Form

   {
        myConn conn = new myConn();
        public app_cust()
        {
            InitializeComponent();
        }

        private void Approve_Click(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update customer set cstatus='Active' where cid=@cid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@Cid", cbx_CID.Text);
            cmd.ExecuteNonQuery();

            lbl_msg.Text = "Customer approved successfully!";
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Close();
        }

        private void cbx_CID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer where cid = @cid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@cid", cbx_CID.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbx_CuName.Text = dr["Cname"].ToString();
                tbx_address.Text = dr["caddress"].ToString();
                tbx_city.Text = dr["city"].ToString();
                tbx_ph1.Text = dr["Ph1"].ToString();
                tbx_ph2.Text = dr["ph2"].ToString();
                tbx_CPName.Text = dr["contectperson"].ToString();
                tbx_CPPh.Text = dr["cpph"].ToString();
                tbx_CPEmail.Text = dr["cemail"].ToString();
                tbx_CreditLimit.Text = dr["creditlimit"].ToString();
                tbx_group.Text = dr["cgroup"].ToString();
            }
            conn.oleDbConnection1.Close();

        }

        private void app_cust_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select cid from customer", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.cbx_CID.Items.Add(dr["CID"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void Disapprove_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update customer set cstatus='Inactive' where cid=@cid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@Cid", cbx_CID.Text);
            cmd.ExecuteNonQuery();

            lbl_msg.Text = "Customer disapprove!";
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Close();
        }
    }
}
