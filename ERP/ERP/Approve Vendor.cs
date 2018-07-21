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
    public partial class Approve_Vendor : Form
    {
        public Approve_Vendor()
        {
            InitializeComponent();
        }
        myConn conn = new myConn();

        private void Approve_Vendor_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vstatus='Open'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox1.Items.Add(dr["vid"].ToString());
            }
            conn.oleDbConnection1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vid=@vid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", comboBox1.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               tbx_vname.Text = dr["vname"].ToString();
                tbx_vcode.Text = dr["cpname"].ToString();
                tbx_city.Text = dr["cpph"].ToString();
                tbx_ph1.Text = dr["ph1"].ToString();
                tbx_ph2.Text = dr["ph2"].ToString();
                tbx_address.Text = dr["vaddress"].ToString();
                tbx_cname.Text = dr["cpname"].ToString();
                tbx_cPh.Text = dr["cpph"].ToString();
                tbx_cEmail.Text = dr["vemail"].ToString();
                tbx_cFax.Text = dr["vfax"].ToString();
                

            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Active' where vid=@vid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", comboBox1.Text);
            cmd.ExecuteNonQuery();

            lbl_msg.Text = "Vendor approved successfully!";
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Inactive' where vid=@vid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", comboBox1.Text);
            cmd.ExecuteNonQuery();

            lbl_msg.Text = "Vendor set to inactive successfully!";
            conn.oleDbConnection1.Close();


            conn.oleDbConnection1.Close();
        }
    }
}
