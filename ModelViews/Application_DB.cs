using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Rental_App_V1._0.Models;


namespace Rental_App_V1._0.ModelViews
{
    internal class Application_DB
    {
        internal string connectionString = "Data Source=localhost\\VPDBOOP;Initial Catalog=VPDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Student CheckIfExist(String id)
        {
            string query = $"SELECT * FROM studentData WHERE StudentID = '{id}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Student student = new Student(reader.GetString(reader.GetOrdinal("StudentID")), reader.GetString(reader.GetOrdinal("Name")), reader.GetInt32(reader.GetOrdinal("Age")), reader.GetString(reader.GetOrdinal("Program")));
                            connection.Close();
                            return student;
                        }
                        else
                        {
                            connection.Close();
                            return null;
                        }
                    }
                }
            }
        }
        public DataTable ImportData()
        {
            string query = "SELECT ItemID, Name, Category, RentPerDay, ItemImage FROM itemList";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();

                        dt.Columns.Add("ItemID", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("Category", typeof(string));
                        dt.Columns.Add("RentPerDay", typeof(int));
                        dt.Columns.Add("ItemImage", typeof(Image));


                        while (reader.Read())
                        {

                            int itemId = reader.GetInt32(reader.GetOrdinal("ItemID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            string category = reader.GetString(reader.GetOrdinal("Category"));
                            int price = reader.GetInt32(reader.GetOrdinal("RentPerDay"));
                            string imagePath = reader.GetString(reader.GetOrdinal("ItemImage"));

                            Image itemImage = null;
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                            {
                                try
                                {
                                    itemImage = Image.FromFile(imagePath);
                                    itemImage = ResizeImage(itemImage, 200, 200);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error loading image: " + ex.Message);

                                }
                            }
                            
                            dt.Rows.Add(itemId, name, category, price, itemImage);
                            
                        }
                        connection.Close();
                        return dt;
                    }
                }
            }
        }
            //Filtered DataTable
        public DataTable ImportData(string categorie)
        {
        string query = $"SELECT ItemID, Name, Category, RentPerDay, ItemImage FROM itemList WHERE Category = '{categorie}'";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();

                    dt.Columns.Add("ItemID", typeof(int));
                    dt.Columns.Add("Name", typeof(string));
                    dt.Columns.Add("Category", typeof(string));
                    dt.Columns.Add("RentPerDay", typeof(int));
                    dt.Columns.Add("ItemImage", typeof(Image));


                    while (reader.Read())
                    {
                        int itemId = reader.GetInt32(reader.GetOrdinal("ItemID"));
                        string name = reader.GetString(reader.GetOrdinal("Name"));
                        string category = reader.GetString(reader.GetOrdinal("Category"));
                        int price = reader.GetInt32(reader.GetOrdinal("RentPerDay"));
                        string imagePath = reader.GetString(reader.GetOrdinal("ItemImage"));

                        Image itemImage = null;
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            try
                            {
                                itemImage = Image.FromFile(imagePath);
                                itemImage = ResizeImage(itemImage, 200, 200);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error loading image: " + ex.Message);

                            }
                        }
                        dt.Rows.Add(itemId, name, category, price, itemImage);
                    }
                    connection.Close();
                    return dt;
                }
            }
        }
    }

    private Image ResizeImage(Image imgToResize, int width, int height)
    {
        return (Image)(new Bitmap(imgToResize, new Size(width, height)));
    }
    }
}
