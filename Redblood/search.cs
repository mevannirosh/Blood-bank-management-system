using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Redblood
{
    public partial class search : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pavan\Documents\BloodBank.mdf;Integrated Security=True;Connect Timeout=30");
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
           
            toolTip2.SetToolTip(btnSearchdata, "Search donors!");
            toolTip2.SetToolTip(btnDelete, "Delete record!");
            con.Open();
            string sq = "select * from Donordetails ";
            SqlDataAdapter ad = new SqlDataAdapter(sq, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDonor.DataSource = dt;
            con.Close();

        }
        

        private void btnSearchdata_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string sq = "select * from Donordetails where Bloodgroup='"+cmbBloodgrp2.SelectedItem+"'";
            SqlDataAdapter ad = new SqlDataAdapter(sq, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvDonor.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string sl = "delete from Donordetails where DNO=" + Convert.ToInt32(txtDno2.Text) + " ";
            SqlCommand cmd = new SqlCommand(sl, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data deleted");
        }
    }
}
