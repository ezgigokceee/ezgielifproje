namespace project2
{
    partial class RecipeDetails
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRECIPE_MEMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECIPE_MEMBER_RATIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECIPE_MEMBER_RATIOUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECIPE_MEMBERDESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRECIPE_ITEM_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(948, 540);
            this.splitContainerControl1.SplitterPosition = 582;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(582, 540);
            this.splitContainerControl2.SplitterPosition = 32;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tarif İçerik Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(project2.RECIPE_ITEMS);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(578, 494);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRECIPE_MEMBER,
            this.colRECIPE_MEMBER_RATIO,
            this.colRECIPE_MEMBER_RATIOUNIT,
            this.colRECIPE_MEMBERDESC,
            this.colRECIPE_ITEM_NUMBER});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            //this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colRECIPE_MEMBER
            // 
            this.colRECIPE_MEMBER.FieldName = "RECIPE_MEMBER";
            this.colRECIPE_MEMBER.Name = "colRECIPE_MEMBER";
            this.colRECIPE_MEMBER.Visible = true;
            this.colRECIPE_MEMBER.VisibleIndex = 0;
            // 
            // colRECIPE_MEMBER_RATIO
            // 
            this.colRECIPE_MEMBER_RATIO.FieldName = "RECIPE_MEMBER_RATIO";
            this.colRECIPE_MEMBER_RATIO.Name = "colRECIPE_MEMBER_RATIO";
            this.colRECIPE_MEMBER_RATIO.Visible = true;
            this.colRECIPE_MEMBER_RATIO.VisibleIndex = 1;
            // 
            // colRECIPE_MEMBER_RATIOUNIT
            // 
            this.colRECIPE_MEMBER_RATIOUNIT.FieldName = "RECIPE_MEMBER_RATIOUNIT";
            this.colRECIPE_MEMBER_RATIOUNIT.Name = "colRECIPE_MEMBER_RATIOUNIT";
            this.colRECIPE_MEMBER_RATIOUNIT.Visible = true;
            this.colRECIPE_MEMBER_RATIOUNIT.VisibleIndex = 2;
            // 
            // colRECIPE_MEMBERDESC
            // 
            this.colRECIPE_MEMBERDESC.FieldName = "RECIPE_MEMBERDESC";
            this.colRECIPE_MEMBERDESC.Name = "colRECIPE_MEMBERDESC";
            this.colRECIPE_MEMBERDESC.Visible = true;
            this.colRECIPE_MEMBERDESC.VisibleIndex = 3;
            // 
            // colRECIPE_ITEM_NUMBER
            // 
            this.colRECIPE_ITEM_NUMBER.FieldName = "RECIPE_ITEM_NUMBER";
            this.colRECIPE_ITEM_NUMBER.Name = "colRECIPE_ITEM_NUMBER";
            this.colRECIPE_ITEM_NUMBER.Visible = true;
            this.colRECIPE_ITEM_NUMBER.VisibleIndex = 4;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(356, 540);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // RecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 540);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "RecipeDetails";
            this.Text = "RecipeDetails";
            this.Load += new System.EventHandler(this.RecipeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            this.splitContainerControl2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRECIPE_MEMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colRECIPE_MEMBER_RATIO;
        private DevExpress.XtraGrid.Columns.GridColumn colRECIPE_MEMBER_RATIOUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colRECIPE_MEMBERDESC;
        private DevExpress.XtraGrid.Columns.GridColumn colRECIPE_ITEM_NUMBER;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}