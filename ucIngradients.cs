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
using DevExpress.XtraRichEdit.Model;
using System.Data.SqlClient;

namespace project2
{
    public partial class ucIngradients : DevExpress.XtraEditors.XtraUserControl
    {
        public string tmpusername;
        public ucIngradients()
        {
            InitializeComponent();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string[] tmpingredients = richTextBox1.Text.Split(',');

            // Parametre oluşturarak SQL sorgusunu güvenli bir şekilde oluşturmak
            string sqlcommand = @"
    SELECT * FROM RECIPES 
    INNER JOIN RECIPE_ITEMS ON RECIPES.ID = RECIPE_ITEMS.RECIPE_ID
    WHERE RECIPE_MEMBER_ALLERGEN_ID NOT IN (
        SELECT ID FROM ALLERGENS 
        WHERE PALLERGENS IN (
            SELECT ALLERGEN_NAME 
            FROM USER_ALLERGENS 
            WHERE [USER] = '" + tmpusername + @"'
        )
    )
    AND RECIPE_TYPE = '" + comboBoxEdit1.SelectedText + @"'
    AND RECIPE_PERSON = " + numericUpDown1.Value;

            if (richTextBox1.Text.Trim() != "")
            {
                sqlcommand += " AND RECIPE_MEMBER IN ('" + string.Join("','", tmpingredients) + "')";
            }

            string connectionString = "Data Source=POYRAZPC;Initial Catalog=COOKSGRAM;Integrated Security=True;MultipleActiveResultSets=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.ConnectionString = connectionString;
                // SqlCommand ve SqlParameter kullanarak SQL sorgusunu çalıştırma
                using (SqlCommand command = new SqlCommand(sqlcommand, con))
                {
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    // DataTable'ı gridControl1'e atayın
                    gridControl1.DataSource = dataTable;
                }
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1 != null && gridView1.FocusedRowHandle >= 0)
            {
                Dictionary<string, object> rowData = new Dictionary<string, object>();

                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
                {
                    rowData.Add(column.FieldName, gridView1.GetRowCellValue(gridView1.FocusedRowHandle, column));
                }
                int tmp = Convert.ToInt32(rowData["ID"]);
                RecipeDetails recipeDetails = new RecipeDetails();
                recipeDetails.recipeID = tmp;
                recipeDetails.Show();
                
            }
        }
    }
}
