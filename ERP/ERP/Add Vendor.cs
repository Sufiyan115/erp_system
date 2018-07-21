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
    public partial class Add_Vendor : Form
    {

    
        public Add_Vendor()
        {
            InitializeComponent();
        }
        myConn conn = new myConn();
        private void Add_Vendor_Load(object sender, EventArgs e)
        {
            int CID = 0;
           conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select count(vID) from vendor", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CID = Convert.ToInt32(dr[0]);
                CID++;
            }
            conn.oleDbConnection1.Close();
            this.tbx_id.Text = "VEN" + "-" + CID + "-" + System.DateTime.Today.Year;

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into vendor(vid, vname ,vcode,vcity,ph1,ph2,vaddress,cpname,cpph, vemail,vfax,vstatus)values(@vid, @vname ,@vcode,@vcity,@ph1,@ph2,@vaddress,@cpname,@cpph, @vemail,@vfax,@vstatus);", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@vid", tbx_id.Text);
                cmd.Parameters.AddWithValue("@vname", tbx_vname.Text);
                cmd.Parameters.AddWithValue("@vcode", tbx_vcode.Text);
                cmd.Parameters.AddWithValue("@vcity", tbx_city.Text);
                cmd.Parameters.AddWithValue("@ph1", int.Parse(tbx_ph1.Text));
                cmd.Parameters.AddWithValue("@ph2", int.Parse(tbx_ph2.Text));
                cmd.Parameters.AddWithValue("@vaddress", tbx_address.Text);
                cmd.Parameters.AddWithValue("@cpname", tbx_cname.Text);
                cmd.Parameters.AddWithValue("@cpph", int.Parse(tbx_cPh.Text));
                cmd.Parameters.AddWithValue("@vemail", tbx_cEmail.Text);
                cmd.Parameters.AddWithValue("@vfax", tbx_cFax.Text);
                cmd.Parameters.AddWithValue("@status", "Open");
                cmd.ExecuteNonQuery();
                lbl_msg.Text = "Data inserted successfully!";
                conn.oleDbConnection1.Close();
            }
            catch(Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbx_address.Clear();
            
            tbx_cEmail.Clear();
            tbx_cFax.Clear();
            tbx_city.Clear();
            tbx_cname.Clear();
            tbx_cPh.Clear();
            tbx_id.Clear();
            tbx_ph1.Clear();
            tbx_ph2.Clear();
            tbx_vcode.Clear();
            tbx_vname.Clear();
            lbl_msg.Text = "";
        }
    }
}
