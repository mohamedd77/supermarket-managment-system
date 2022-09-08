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
    public partial class changeproduct : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public changeproduct()
        {
            InitializeComponent();
        }

        private void changeproduct_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            cmb_p_id.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetProductID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("text", txt_c_name.Text);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_p_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_c_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select customer_Name from Customer where Customer_ID=:id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_c_id.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_c_name.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update customer_product set product_id=:idp where customer_ID =:id and product_id=:idps";
            cmd.Parameters.Add("idp", txt_new_id.Text);
            cmd.Parameters.Add("id", cmb_c_id.SelectedItem.ToString());
            cmd.Parameters.Add("idps", cmb_p_id.SelectedItem.ToString());

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("payment modified");
                cmb_p_id.Text = "";
                cmb_c_id.Text = "";
                txt_c_name.Text = "";
                txt_new_id.Text = "";
            }
        }
    }
}
