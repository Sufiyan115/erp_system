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
    public partial class poform : Form
    {
        public poform()
        {
            InitializeComponent();
        }
        myConn conn = new myConn();

        private void poform_Load(object sender, EventArgs e)
        {
            i = 0;
            int CID = 0;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd1 = new OleDbCommand("select count(poid) from po", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                CID = Convert.ToInt32(dr1[0]);
                CID++;
            }
            conn.oleDbConnection1.Close();
            this.textBox1.Text = "PO" + "-" + CID + "-" + System.DateTime.Today.Year;
            this.textBox6.Text = "0000" + CID;

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vstatus='Active'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox1.Items.Add(dr["vid"].ToString());
            }
            conn.oleDbConnection1.Close();



            conn.oleDbConnection1.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from dept", conn.oleDbConnection1);
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                this.comboBox2.Items.Add(dr2["deptname"].ToString());
            }
            conn.oleDbConnection1.Close();

            conn.oleDbConnection1.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from products", conn.oleDbConnection1);
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                this.comboBox3.Items.Add(dr3["pid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from vendor where vid=@vid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@vid", comboBox1.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["vname"].ToString();
                textBox3.Text = dr["cpname"].ToString();
                textBox4.Text = dr["cpph"].ToString();

            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from products where pid=@pid ", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@pid", comboBox3.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox8.Text = dr["pname"].ToString();

                textBox7.Text = dr["baseprice"].ToString();

            }
            conn.oleDbConnection1.Close();

           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                total = Convert.ToInt32(textBox7.Text) * Convert.ToInt32(textBox9.Text);
                textBox10.Text = total.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }
            finally
            {
                textBox9.Clear();
            }

        }
        int[] amount = new int[10];
        //int[] tot_amnt = new int[10];
        int i;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conn.oleDbConnection1.Open();
                OleDbCommand cmd1 = new OleDbCommand("insert into poproducts (poid,pid,pname, pqty) values (@poid,@pid, @pname ,@pqty)", conn.oleDbConnection1);

                cmd1.Parameters.AddWithValue("@poid", textBox1.Text);
                cmd1.Parameters.AddWithValue("@pid", comboBox3.Text);
                cmd1.Parameters.AddWithValue("@pname", textBox8.Text);
                cmd1.Parameters.AddWithValue("@pqty", textBox9.Text);

                cmd1.ExecuteNonQuery();

                conn.oleDbConnection1.Close();
            }
            catch(Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select pid,pname,pqty from POProducts where poid = @poid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@poid", textBox1.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();

            try
            {
                amount[i] = Convert.ToInt32(textBox10.Text);
                i++;
                int total_amount = 0;
                for (int c = 0; c <= amount.Length; c++)
                {
                    total_amount += Convert.ToInt32(textBox10.Text);
                }
                textBox5.Text = total_amount.ToString();
                comboBox3.Text = "";
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
            OleDbCommand cmd1 = new OleDbCommand("insert into po (poid, podate, ddate, status, approve ,vdept, vname, vid, vcontectperson, vcpph, totalamount, sno, goodrecieved) values (@poid, @podate, @status, @ddate, @approve, @vdept,@vname, @vid, @vcontectperson, @vcpph, @totalamount, @sno, @goodrecieved)", conn.oleDbConnection1);
            cmd1.Parameters.AddWithValue("@poid", textBox1.Text);
            cmd1.Parameters.AddWithValue("@podate", dateTimePicker1);
            cmd1.Parameters.AddWithValue("@ddate", dateTimePicker2);
            cmd1.Parameters.AddWithValue("@status", "Open");
            cmd1.Parameters.AddWithValue("@approve", "Approved");
            cmd1.Parameters.AddWithValue("@vdept", comboBox2.Text);
            cmd1.Parameters.AddWithValue("@vname", textBox2.Text);
            cmd1.Parameters.AddWithValue("@vid", comboBox1.Text);
            cmd1.Parameters.AddWithValue("@Vcontectperson", textBox3.Text);
            cmd1.Parameters.AddWithValue("@vcpph", textBox4.Text);
            cmd1.Parameters.AddWithValue("@totalamount", textBox5.Text);
            cmd1.Parameters.AddWithValue("@sno", textBox6.Text);
            cmd1.Parameters.AddWithValue("@goodrecieved", "No");
            cmd1.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            lbl_msg.Text = "PO Generated Successfully!";

        }
            catch (Exception)
            {

                MessageBox.Show("Plese insert values correctly!");
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
