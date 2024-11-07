using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_App_V1._0.Models
{
    internal class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Image Image { get; set; }

        public string ImageAddress {  get; set; }

        public Item(int item, string name, string description, double price, int quantity, Image image, string imageAddress)
        {
            ItemID = item;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Image = image;
            ImageAddress = imageAddress;
        }


    }
}
