using DevExpress.XtraEditors;
using project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookGram
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 1)
            {
                txtname.Visible = true;
                txtsurname.Visible = true;
                txtemail.Visible = true;
            }
            else
            {
                txtname.Visible = false;
                txtsurname.Visible = false;
                txtemail.Visible = false;
            }
        }
        public void signin()
        {
            COOKSGRAMEntities cOOKSGRAMEntities = new COOKSGRAMEntities();
            
            try
            {
                USERS uSERS = new USERS();
                uSERS.ID = 0;
                uSERS.NAME = txtname.Text;
                uSERS.SURNAME = txtsurname.Text;
                uSERS.EMAİL = txtemail.Text;
                uSERS.USERNAME = txtusername.Text;
                uSERS.PASSWORD = txtpassword.Text;
                uSERS.LOGDATETIME = DateTime.Now;
                cOOKSGRAMEntities.USERS.Add(uSERS);
                cOOKSGRAMEntities.SaveChanges();
                HomePage homePage = new HomePage();
                homePage.tmpuser = txtusername.Text;
                homePage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            
        }
        public void signup()
        {
            COOKSGRAMEntities cOOKSGRAMEntities = new COOKSGRAMEntities();
            var existuser = cOOKSGRAMEntities.USERS.FirstOrDefault(p => p.USERNAME == txtusername.Text && p.PASSWORD == txtpassword.Text);
            if (existuser != null)
            {
                HomePage homePage = new HomePage();
                homePage.tmpuser = txtusername.Text;
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 1)
            {
                this.signin();
            }
            else
            {
                this.signup();
            }

        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
        }

        private void txtname_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
        }

        private void txtsurname_Click(object sender, EventArgs e)
        {
            txtsurname.Text = "";
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}