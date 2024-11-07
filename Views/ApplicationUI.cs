using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Rental_App_V1._0.Models;
using Rental_App_V1._0.ModelViews;


namespace Rental_App_V1._0.Views
{
    public partial class ApplicationUI : Form
    {
        public ApplicationUI()
        {
            startPanel();
        }

        Application_DB appDB = new Application_DB();
        void startPanel()
        {
            InitializeComponent();
            SplashScreen.Visible = true;
        }

        private void ApplicationUI_Load(object sender, EventArgs e)
        {
            SplashScreen.Visible = true;
        }


        private void SplashScreen_Click(object sender, EventArgs e)
        {
            SplashScreen.Visible = false;
            LoginScreen.Visible = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (appDB.CheckIfExist(IDInput.Text) != null)
            {
                Student student = appDB.CheckIfExist(IDInput.Text);
                StudentLoginName.Text = student.Name;
                StudentLoginID.Text = student.StudentID;
                StudentLoginProgram.Text = student.Program;
                StudentLoginAge.Text = student.Age.ToString();
                LoginScreen.Visible = false;
                CheckStudent.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }

        private void GridViewItem_Click(object sender, DataGridViewCellMouseEventArgs ee)
        {

            DialogResult result = MessageBox.Show("Do you want to add this item to the cart?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int itemID = Convert.ToInt32(DTIMAGETEST.Rows[ee.RowIndex].Cells[0].Value);
                string studentID = IDInput.Text;
                string itemName = DTIMAGETEST.Rows[ee.RowIndex].Cells[1].Value.ToString();
                string itemCategory = DTIMAGETEST.Rows[ee.RowIndex].Cells[2].Value.ToString();
                double itemPrice = Convert.ToDouble(DTIMAGETEST.Rows[ee.RowIndex].Cells[3].Value);
                string itemImage = DTIMAGETEST.Rows[ee.RowIndex].Cells[5].Value.ToString();
                int rentDays = Convert.ToInt32(CBODayRent.Text);

                Cart cart = new Cart(itemID, studentID, itemName, itemCategory, itemPrice, itemImage, rentDays, rentDays * itemPrice);

                Application_DB appDB = new Application_DB();
                
                if (appDB.exportData(cart))
                {
                    MessageBox.Show("Item Added to Cart");

                    GridViewScreen.Visible = false;
                    ReceiptScreen.Visible = true;

                    DataTable tb = appDB.importCart(studentID);
                    GRDCRT.DataSource = tb;

                }
                else
                {
                    MessageBox.Show("Item Not Added to Cart");
                }








            }
        }

        private void CartScreen_Click(object sender, EventArgs e)
        {
            CartScreen.Visible = false;
            ReceiptScreen.Visible = true;
        }

        private void ReceiptScreen_Click(object sender, EventArgs e)
        {
            CartScreen.Visible = false;
        }

        private void EndScreen_Click(object sender, EventArgs e)
        {
            EndScreen.Visible = false;
            SplashScreen.Visible = true;
        }

        private void Load_Device_Data(object sender, EventArgs e)
        {
            TableLabel.Text = "ELECTRONICS";
            DTIMAGETEST.DataSource = null;
            Application_DB appDB = new Application_DB();
            DataTable dt = appDB.ImportData("Electronics");
            DTIMAGETEST.DataSource = dt;
            DTIMAGETEST.Columns[5].Visible = false;
        }

        private void Load_Clothing_Data(object sender, EventArgs e)
        {
            TableLabel.Text = "CLOTHING & ACCESSORIES";
            DTIMAGETEST.DataSource = null;
            Application_DB appDB = new Application_DB();
            DataTable dt = appDB.ImportData("Clothing & Accessories");
            DTIMAGETEST.DataSource = dt;
            DTIMAGETEST.Columns[5].Visible = false;
        }

        private void Load_Home_Data(object sender, EventArgs e)
        {
            TableLabel.Text = "HOME & GARDEN";
            DTIMAGETEST.DataSource = null;
            Application_DB appDB = new Application_DB();
            DataTable dt = appDB.ImportData("Home & Garden");
            DTIMAGETEST.DataSource = dt;
            DTIMAGETEST.Columns[5].Visible = false;
        }

        private void Load_Tool_Data(object sender, EventArgs e)
        {
            TableLabel.Text = "TOOLS & EQUIPMENT";
            DTIMAGETEST.DataSource = null;
            Application_DB appDB = new Application_DB();
            DataTable dt = appDB.ImportData("Tools & Equipment");
            DTIMAGETEST.DataSource = dt;
            DTIMAGETEST.Columns[5].Visible = false;
        }

        private void Check_No(object sender, EventArgs e)
        {
            CheckStudent.Visible = false;
            LoginScreen.Visible = true;

            StudentLoginName.Text = "";
            StudentLoginID.Text = "";
            StudentLoginProgram.Text = "";
            StudentLoginAge.Text = "";
        }

        private void Check_Yes(object sender, EventArgs e)
        {
            CheckStudent.Visible = false;
            GridViewScreen.Visible = true;
            
            CBODayRent.Text = "1";
            DataTable dt = appDB.ImportData("Electronics");
            DTIMAGETEST.DataSource = dt;

            StudentLoginName.Text = "";
            StudentLoginID.Text = "";
            StudentLoginProgram.Text = "";
            StudentLoginAge.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApplicationUI_Load_1(object sender, EventArgs e)
        {

        }

        private void ADD_ITEM(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DTIMAGETEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifyDB(object sender, KeyEventArgs e)
        {
            Application_DB appDB = new Application_DB();
            DTIMAGETEST.DataSource = null;
            if (SearchBox.Text != "")
            {
                DataTable dt = appDB.searchFilter(SearchBox.Text, TableLabel.Text);
                DTIMAGETEST.DataSource = dt;
                DTIMAGETEST.Columns[5].Visible = false;
            }
            else
            {
                DataTable dt = appDB.ImportData(TableLabel.Text);
                DTIMAGETEST.DataSource = dt;
                DTIMAGETEST.Columns[5].Visible = false;
            }
        }
    }
}
