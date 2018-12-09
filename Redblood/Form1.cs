using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redblood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSandwich_Click(object sender, EventArgs e)
        {
            if(pnlSliding.Width== 50)
            {
                pnlSliding.Visible = false;
                pnlSliding.Width = 208;
                PanelTransition2.ShowSync(pnlSliding);
                LogoTransition.ShowSync(Logo);
                
            }
            else
            {
                LogoTransition.Hide(Logo);
                pnlSliding.Visible = false;
                pnlSliding.Width = 50;
                PanelTransition2.ShowSync(pnlSliding);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmRegister temp = new frmRegister();
            temp.TopLevel = false;
            pnlMain.Controls.Add(temp);
            temp.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            search temp = new search();
            temp.TopLevel = false;
            pnlMain.Controls.Add(temp);
            temp.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmHomepage temp = new frmHomepage();
            temp.TopLevel = false;
            pnlMain.Controls.Add(temp);
            temp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmHomepage temp = new frmHomepage();
            temp.TopLevel = false;
            pnlMain.Controls.Add(temp);
            temp.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmProgress temp = new frmProgress();
            temp.TopLevel = false;
            pnlMain.Controls.Add(temp);
            temp.Show();
        }
    }
}
