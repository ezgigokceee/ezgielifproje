using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace project2
{
    public partial class RecipeDetails : DevExpress.XtraEditors.XtraForm
    {
        public int recipeID;
        public RecipeDetails()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            COOKSGRAMEntities cOOKSGRAMEntities = new COOKSGRAMEntities();
            gridControl1.DataSource = cOOKSGRAMEntities.RECIPE_ITEMS.Where(entity => entity.RECIPE_ID == recipeID).ToList();
        }

        private void RecipeDetails_Load(object sender, EventArgs e)
        {
            loaddata();
            richTextBox1.Text = "";
            if (gridView1 != null && gridView1.FocusedRowHandle >= 0)
            {
                Dictionary<string, object> rowData = new Dictionary<string, object>();

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
                {
                    rowData.Add(column.FieldName, gridView1.GetRowCellValue(gridView1.FocusedRowHandle, column));
                }
                COOKSGRAMEntities cOOKSGRAMEntities = new COOKSGRAMEntities();
                var dt = cOOKSGRAMEntities.RECIPE_STEP.Where(entity => entity.RECIPE_ID == recipeID).ToList();
                foreach (var item in dt)
                {
                    string rowText = "";

                    rowText += item.RECIPE_STEP_SEQ + "\t" + item.RECIPE_STEP_DESC;
                    rowText += Environment.NewLine;
                    richTextBox1.AppendText(rowText);
                }
            }
        }

        //private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    richTextBox1.Text = "";
        //    if (gridView1 != null && gridView1.FocusedRowHandle >= 0)
        //    {
        //        Dictionary<string, object> rowData = new Dictionary<string, object>();

        //        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
        //        {
        //            rowData.Add(column.FieldName, gridView1.GetRowCellValue(gridView1.FocusedRowHandle, column));
        //        }
        //        COOKSGRAMEntities cOOKSGRAMEntities = new COOKSGRAMEntities();
        //        var dt = cOOKSGRAMEntities.RECIPE_STEP.Where(entity => entity.RECIPE_ID == recipeID).ToList();
        //        foreach (var item in dt)
        //        {
        //            string rowText = "";

        //            rowText +=  item.RECIPE_STEP_SEQ + "\t" + item.RECIPE_STEP_DESC;
        //            rowText += Environment.NewLine;
        //            richTextBox1.AppendText(rowText);
        //        }
        //    }
        //}
    }
}