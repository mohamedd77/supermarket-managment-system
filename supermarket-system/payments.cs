using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace Supermarket_Management_System
{
    public partial class payments : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public payments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select customer_ID from customer";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_c_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select customer_Name from Customer where Customer_ID=:id ";
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.Add("id", cmb_c_id.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txt_c_name.Text = dr[0].ToString();
                txt_p_name.Text = "";
                txt_p_price.Text = "";
                txt_bill.Text = "";
                cmb_p_id.Text = "";
            }
            dr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into customer_product values (:id,:idp)";
            cmd.Parameters.Add("id", cmb_c_id.Text);
            cmd.Parameters.Add("idp", cmb_p_id.Text);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("New payment is added");
                txt_p_name.Text = "";
                txt_p_price.Text = "";
                txt_bill.Text = "";
                cmb_p_id.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeproduct f4 = new changeproduct();
            f4.Show();
            cmb_c_id.Text = "";
            txt_c_name.Text = "";
            txt_p_name.Text = "";
            txt_p_price.Text = "";
            txt_bill.Text = "";
            cmb_p_id.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from customer_product where customer_id=:id and product_id=:idps";
            cmd.Parameters.Add("id", cmb_c_id.Text);
            cmd.Parameters.Add("idps", cmb_p_id.Text);
            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("payment deleted");
                cmb_p_id.Items.RemoveAt(cmb_p_id.SelectedIndex);
                txt_p_name.Text = "";
                txt_p_price.Text = "";
                txt_bill.Text = "";
                cmb_p_id.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            cmb_p_id.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetProductID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("text", txt_c_name.Text);
            cmd.Parameters.Add("id",OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmb_p_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_p_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select products_Name, products_price from product where products_ID=:id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_p_id.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_p_name.Text = dr[0].ToString();
                txt_p_price.Text = dr[1].ToString();
            }
            dr.Close();
        }

        private void txt_p_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bill_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Getbill";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("c_id", cmb_c_id.Text);
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            txt_bill.Text = cmd.Parameters["id"].Value.ToString();
        }

        private void btn_add_c_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into customer values (:id,:name)";
            cmd.Parameters.Add("id", cmb_c_id.Text);
            cmd.Parameters.Add("name", txt_c_name.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_c_id.Items.Add(cmb_c_id.Text);
                MessageBox.Show("New customer is added");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update customer set customer_name=:name where customer_ID =:id";
            cmd.Parameters.Add("name", txt_c_name.Text);
            cmd.Parameters.Add("id", cmb_c_id.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Customer modified");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from customer where customer_id=:id";
            cmd.Parameters.Add("id", cmb_c_id.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("customer deleted");
                cmb_c_id.Items.RemoveAt(cmb_c_id.SelectedIndex);
                txt_c_name.Text = "";
            }
        }

        private void hover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(btn_insert, "you can add product by choosing the customer id and the product id");
        }

        private void hover_delete(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(btn_delete, "it will delete the product that you choosed in the combobox");
        }
    }
}
