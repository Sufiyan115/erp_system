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
    public partial class addCustomer : Form
    {
        myConn conn = new myConn();
        public addCustomer()
        {
            InitializeComponent();
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

            int CID = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(CID) from customer", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                CID = Convert.ToInt32(dr[0]);
                CID++;
            }
       
            conn.oleDbConnection1.Close();
            tbx_cid.Text = "CID-" + CID + "-" + System.DateTime.Today.Year;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from dept", conn.oleDbConnection1);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                this.cbx_group.Items.Add(dr2["deptname"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into customer(cid, cname, caddress, city, ph1, ph2, contectperson, cpph, cemail, creditlimit, cstatus, cgroup) values(@cid, @cname, @caddress, @city, @ph1, @ph2, @contectperson, @cpph, @cemail, @creditlimit, @cstatus, @cgroup)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@cid", tbx_cid.Text);
                cmd.Parameters.AddWithValue("@cname", tbx_CuName.Text);
                cmd.Parameters.AddWithValue("@caddress", tbx_address.Text);
                cmd.Parameters.AddWithValue("@city", tbx_city.Text);
                cmd.Parameters.AddWithValue("ph1", Convert.ToInt32(tbx_ph1.Text));
                cmd.Parameters.AddWithValue("ph2", Convert.ToInt32(tbx_ph2.Text));
                cmd.Parameters.AddWithValue("@contectperson", tbx_CPName.Text);
                cmd.Parameters.AddWithValue("@cpph", Convert.ToInt32(tbx_CPPh.Text));
                cmd.Parameters.AddWithValue("@Cemail", tbx_CPEmail.Text);
                cmd.Parameters.AddWithValue("@CreditLimit", tbx_CreditLimit.Text);
                cmd.Parameters.AddWithValue("@Cstatus", "Open");
                cmd.Parameters.AddWithValue("@cgroup", cbx_group.Text);
                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
            }
            catch(Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }

            lbl_msg.Text = "Customer added Successfully!";
        }
    }
}
