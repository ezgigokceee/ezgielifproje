namespace CookGram
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.txtusername = new DevExpress.XtraEditors.TextEdit();
            this.txtsurname = new DevExpress.XtraEditors.TextEdit();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.svgImageBox1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.txtemail);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtpassword);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtusername);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtsurname);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtname);
            this.splitContainerControl1.Panel2.Controls.Add(this.radioGroup1);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(741, 418);
            this.splitContainerControl1.SplitterPosition = 330;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(122, 292);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 31);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "LOGIN";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(71, 86);
            this.svgImageBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(192, 198);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 0;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // txtemail
            // 
            this.txtemail.EditValue = "EMAIL";
            this.txtemail.Location = new System.Drawing.Point(0, 190);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(387, 22);
            this.txtemail.TabIndex = 7;
            this.txtemail.Visible = false;
            this.txtemail.EditValueChanged += new System.EventHandler(this.txtemail_EditValueChanged);
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.EditValue = "PASSWORD";
            this.txtpassword.Location = new System.Drawing.Point(0, 94);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Properties.PasswordChar = '*';
            this.txtpassword.Properties.UseSystemPasswordChar = true;
            this.txtpassword.Size = new System.Drawing.Size(387, 22);
            this.txtpassword.TabIndex = 6;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            // 
            // txtusername
            // 
            this.txtusername.EditValue = "USERNAME";
            this.txtusername.Location = new System.Drawing.Point(0, 62);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(387, 22);
            this.txtusername.TabIndex = 5;
            this.txtusername.EditValueChanged += new System.EventHandler(this.txtusername_EditValueChanged);
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            // 
            // txtsurname
            // 
            this.txtsurname.EditValue = "SURNAME";
            this.txtsurname.Location = new System.Drawing.Point(0, 158);
            this.txtsurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(387, 22);
            this.txtsurname.TabIndex = 4;
            this.txtsurname.Visible = false;
            this.txtsurname.Click += new System.EventHandler(this.txtsurname_Click);
            // 
            // txtname
            // 
            this.txtname.EditValue = "NAME";
            this.txtname.Location = new System.Drawing.Point(0, 126);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(387, 22);
            this.txtname.TabIndex = 3;
            this.txtname.Visible = false;
            this.txtname.EditValueChanged += new System.EventHandler(this.txtname_EditValueChanged);
            this.txtname.Click += new System.EventHandler(this.txtname_Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(88, 246);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 2;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Sign Up"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Sign In")});
            this.radioGroup1.Size = new System.Drawing.Size(215, 32);
            this.radioGroup1.TabIndex = 2;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(204, 286);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(98, 43);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "QUIT";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(88, 286);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 43);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "GO";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 418);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtusername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.TextEdit txtpassword;
        private DevExpress.XtraEditors.TextEdit txtusername;
        private DevExpress.XtraEditors.TextEdit txtsurname;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}