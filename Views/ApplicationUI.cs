using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Rental_App_V1._0.Views
{
    public partial class ApplicationUI : Form
    {
        public ApplicationUI()
        {
            startPanel();
        }

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
            LoginScreen.Visible = false;
            GridViewScreen.Visible = true;
        }

        private void GridViewScreen_Click(object sender, EventArgs e)
        {
            GridViewScreen.Visible = false;
            CartScreen.Visible = true;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
