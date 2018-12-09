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
    public partial class frmRegister : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pavan\Documents\BloodBank.mdf;Integrated Security=True;Connect Timeout=30");
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSave,"Save Details of the new donor!");
            toolTip1.SetToolTip(btnReset,"Empty the details!");
            toolTip1.SetToolTip(btnUpdate, "Update record!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dno = txtDno.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string telno = txtTel.Text;
            string address = txtAddress.Text;
            string country = txtCountry.Text;
            string mail = txtEmail.Text;
            string province = txtProvince.Text;
            string city = txtCity.Text;
            
            if (dno=="")
            {
                MessageBox.Show("Donor No field is incorrect or empty!");
            }

            if (fname == "" || fname.All(char.IsDigit))
            {
                MessageBox.Show("First name field is incorrect or empty!");
            }

            if (lname == "" || lname.All(char.IsDigit))
            {
                MessageBox.Show("Last name field is incorrect or empty!");
            }

            if (cmbBloodgrp.SelectedIndex == -1)
            {
                MessageBox.Show("Select a blood group");
            }

            if (cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Select a birth year");
            }
            if (telno == "" || txtTel.TextLength != 10)
            {
                MessageBox.Show("Telno field is incorrect or empty!");
            }
            if (address == "" )
            {
                MessageBox.Show("Address field is incorrect or empty!");
            }
            if (cmbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Select a gender");
            }
            if (country == "" || country.All(char.IsDigit))
            {
                MessageBox.Show("Country field is incorrect or empty!");
            }
            if (province == "" || province.All(char.IsDigit))
            {
                MessageBox.Show("Province field is incorrect or empty!");
            }
            if (city=="" || city.All(char.IsDigit))
            {
                MessageBox.Show("City field is incorrect or empty!");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("insert into Donordetails(DNO,Fname,Lname,Bloodgroup,Birthyear,Address,sex,telno,country,province,city,email) values(@DNO,@fname,@lname,@bldgrp,@byear,@address,@sex,@telno,@country,@province,@city,@email)"))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@DNO", txtDno.Text);
                        cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                        cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                        cmd.Parameters.AddWithValue("@bldgrp", cmbBloodgrp.GetItemText(cmbBloodgrp.SelectedItem));
                        cmd.Parameters.AddWithValue("@byear", cmbYear.GetItemText(cmbYear.SelectedItem));
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@sex", cmbSex.GetItemText(cmbSex.SelectedItem));
                        cmd.Parameters.AddWithValue("@telno", txtTel.Text);
                        cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                        cmd.Parameters.AddWithValue("@province", txtProvince.Text);
                        cmd.Parameters.AddWithValue("@city", txtCity.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Record inserted");
                        }
                        else
                        {
                            MessageBox.Show("Record failed");
                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during insert: " + ex.Message);
                }
            }

           



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDno.Clear();
            txtFname.Clear();
            txtLname.Clear();
            cmbBloodgrp.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            txtTel.Clear();
            txtAddress.Clear();
            cmbSex.SelectedIndex = -1;
            txtCountry.Clear();
            txtProvince.Clear();
            txtCity.Clear();
            txtEmail.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string up = "update Donordetails set Bloodgroup="+cmbBloodgrp.SelectedItem+ ",Fname='"+txtFname.Text+"'  where DNO=" + Convert.ToInt32(txtDno.Text) + " ";
            SqlCommand cmd = new SqlCommand(up, con);
            con.Close();
            MessageBox.Show("Data updated");
        }
    }
}
