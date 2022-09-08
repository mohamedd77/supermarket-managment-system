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
    public partial class cashier : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public cashier()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select cashier_name from cashier";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Name.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select gender from cashier where cashier_name=:name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", cmb_Name.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_gender.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Getcashiername";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("title",cmb_Name.SelectedItem);
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            txt_id.Text= cmd.Parameters["id"].Value.ToString();
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into cashier values (:name,:id,:gender)";
            cmd.Parameters.Add("name", cmb_Name.Text);
            cmd.Parameters.Add("id", txt_id.Text);
            cmd.Parameters.Add("gender", txt_gender.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_Name.Items.Add(cmb_Name.Text);
                MessageBox.Show("New cashier is added");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from cashier where cashier_name=:name";
            cmd.Parameters.Add("name", cmb_Name.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("cashier deleted");
                cmb_Name.Items.RemoveAt(cmb_Name.SelectedIndex);
                txt_id.Text = "";
                txt_gender.Text = "";
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update cashier set cashier_id=:id,gender=:gender where cashier_name =:name";
            cmd.Parameters.Add("id", txt_id.Text);
            cmd.Parameters.Add("gender", txt_gender.Text);
            cmd.Parameters.Add("name", cmb_Name.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Cashier modified");
            }
        }
    }
}
