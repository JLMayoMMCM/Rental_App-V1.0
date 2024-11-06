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
        private int ItemID { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }

        public Image Image { get; set; }

        public Item(int item, string name, string description, double price, int quantity, Image image)
        {
            ItemID = item;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Image = image;
        }


    }
}
