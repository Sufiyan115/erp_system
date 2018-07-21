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
    public partial class grnForm : Form
    {
        myConn conn = new myConn();
        public grnForm()
        {
            InitializeComponent();
        }

        private void grnForm_Load(object sender, EventArgs e)
        {
            
            int CID = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(grnid) from grn", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                CID = Convert.ToInt32(dr1[0]);
                CID++;
            }
            conn.oleDbConnection1.Close();
            this.tbx_grnID.Text = "GRN" + "-" + CID + "-" + System.DateTime.Today.Year;
            this.tbx_SerialNo.Text = "00000" + CID;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from po where goodrecieved='no'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.cbx_poID.Items.Add(dr["poid"].ToString());
            }
            conn.oleDbConnection1.Close();




        }

        private void cbx_poID_SelectedIndexChanged(object sender, EventArgs e)
        {

        
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from po where poid=@pid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", cbx_poID.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbx_poDate.Text= dr["podate"].ToString();
                tbx_dDate.Text = dr["ddate"].ToString();
                tbx_vendor.Text = dr["vname"].ToString();
                tbx_vCP.Text = dr["vcontectperson"].ToString();
                tbx_vCph.Text = dr["vcpph"].ToString();
               
            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Close();
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
                OleDbCommand cmd1 = new OleDbCommand("insert into grn (grnid, poid, status,vname, ddate, grdate, sno) values (@grnid, @poid, @status,@vname, @ddate, @grdate, @sno)", conn.oleDbConnection1);
                cmd1.Parameters.AddWithValue("@grnid", tbx_grnID.Text);
                cmd1.Parameters.AddWithValue("@poid", cbx_poID.Text);
                cmd1.Parameters.AddWithValue("@status", "Close");
                cmd1.Parameters.AddWithValue("@vname", tbx_vendor.Text);
                cmd1.Parameters.AddWithValue("@ddate", tbx_dDate.Text);
                cmd1.Parameters.AddWithValue("@grdate", dateTimePicker1);
                cmd1.Parameters.AddWithValue("@sno", Int32.Parse(tbx_SerialNo.Text));
                cmd1.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
            }
            catch(Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }

            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("update po set goodrecieved='Yes' where poid=@poid", conn.oleDbConnection1);
            cmd2.Parameters.AddWithValue("@poid", cbx_poID.Text);
            cmd2.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            lbl_msg.Text = "GRN Generated Successfully!";
        }

        private void tbx_poDate_TextChanged(object sender, EventArgs e)
        {


           
        }

        private void tbx_vCph_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
    }
}
