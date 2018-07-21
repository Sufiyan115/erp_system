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
    public partial class saleOrder : Form
    {

        int[] amount = new int[10];
        myConn conn = new myConn();
        public saleOrder()
        {
            InitializeComponent();
        }

        private void saleOrder_Load(object sender, EventArgs e)
        {
            int CID = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(soid) from so", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                CID = Convert.ToInt32(dr1[0]);
                CID++;
            }
            conn.oleDbConnection1.Close();
            this.tbx_SOID.Text = "SO" + "-" + CID + "-" + System.DateTime.Today.Year;
            this.tbx_Sno.Text = "0000" + CID;


            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer where cstatus='Active'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.cbx_CID.Items.Add(dr["cid"].ToString());
            }
            conn.oleDbConnection1.Close();

           


            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from products", conn.oleDbConnection1);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                this.cbx_PID.Items.Add(dr3["pid"].ToString());
            }
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
                tbx_CDept.Text = dr["cgroup"].ToString();
                tbx_CName.Text = dr["cname"].ToString();
                tbx_CCP.Text = dr["contectperson"].ToString();
                tbx_CPPh.Text = dr["cpph"].ToString();
            }

            conn.oleDbConnection1.Close();
        }

        private void cbx_PID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products where pid=@pid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", cbx_PID.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tbx_PName.Text = dr["pname"].ToString();
                tbx_SPrice.Text = dr["saleprice"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void tbx_Qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                total = Convert.ToInt32(tbx_Qty.Text) * Convert.ToInt32(tbx_SPrice.Text);
               tbx_amount.Text = total.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }
            finally
            {
                tbx_Qty.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("insert into soproducts (soid,pid,pname, pqty) values (@Soid,@pid, @pname ,@pqty)", conn.oleDbConnection1);
                cmd1.Parameters.AddWithValue("@soid", tbx_SOID.Text);
                cmd1.Parameters.AddWithValue("@pid", cbx_PID.Text);
                cmd1.Parameters.AddWithValue("@pname", tbx_PName.Text);
                cmd1.Parameters.AddWithValue("@pqty", tbx_Qty.Text);
                cmd1.ExecuteNonQuery();
                conn.oleDbConnection1.Close();

                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select pid,pname,pqty from SOProducts where Soid = @Soid", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@soid", tbx_SOID.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                conn.oleDbConnection1.Close();

                int[] amount = new int[10];
                int i = 0;
                amount[i] = Convert.ToInt32(tbx_amount.Text);
                i++;
                int total_amount = 0;
                for (int c = 0; c <= amount.Length; c++)
                {
                    total_amount += Convert.ToInt32(tbx_amount.Text);
                }
                tbx_total.Text = total_amount.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("insert into so (soid, sodate, ddate, status, approve ,cdept, cname, cid, ccontectperson, ccpph, totalamount, sno, goodsdelivered) values (@soid, @sodate, @ddate, @status, @approve , @cdept, @cname, @cid, @ccontectperson, @ccpph, @totalamount, @sno, @goodsdelivered)", conn.oleDbConnection1);
                cmd1.Parameters.AddWithValue("@soid", tbx_SOID.Text);
                cmd1.Parameters.AddWithValue("@sodate", dateTimePicker1);
                cmd1.Parameters.AddWithValue("@ddate", dateTimePicker2);
                cmd1.Parameters.AddWithValue("@status", "Open");
                cmd1.Parameters.AddWithValue("@approve", "Approved");
                cmd1.Parameters.AddWithValue("@cdept", tbx_CDept.Text);
                cmd1.Parameters.AddWithValue("@cname", tbx_CName.Text);
                cmd1.Parameters.AddWithValue("@cid", cbx_CID.Text);
                cmd1.Parameters.AddWithValue("@ccontectperson", tbx_CCP.Text);
                cmd1.Parameters.AddWithValue("@ccpph", tbx_CPPh.Text);
                cmd1.Parameters.AddWithValue("@totalamount", tbx_total.Text);
                cmd1.Parameters.AddWithValue("@sno", tbx_Sno.Text);
                cmd1.Parameters.AddWithValue("@goodsdelivered", "No");
                cmd1.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
                lbl_msg.Text = "SO Generated Successfully!";
            }

            catch (Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }
        }
    }
}
