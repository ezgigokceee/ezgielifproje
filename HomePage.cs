using project2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookGram
{
    
    public partial class HomePage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string tmpuser;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            tmpusername.Caption = tmpuser;
            
           
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelControl1.Controls.Clear();
        }

        private void barButtonProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucProfile profile = new ucProfile();
            profile.tmpusername = tmpuser;
            profile.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(profile);
            profile.BringToFront();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucIngradients profile = new ucIngradients();
            profile.tmpusername = tmpuser;
            profile.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(profile);
            profile.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
