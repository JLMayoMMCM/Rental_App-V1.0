﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_App_V1._0.Models
{
    internal class Cart
    {
        public int ItemId { get; set; }

        public string StudentId { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public double RentPerDay { get; set; }

        public string ItemImage { get; set; }

        public int NoOfRentDays { get; set; }

        public double TotalPrice { get; set; }


        public Cart()
        {
            ItemId = 0;
            StudentId = null;
            Name = null;
            Category = null;
            RentPerDay = 0;
            ItemImage = null;
            NoOfRentDays = 0;
            TotalPrice = 0;
        }

        public Cart(int itemID, string studentID, string name, string category, double rentPerDay, string itemImage, int NoOfRentDays, double TotalRentCost)
        {
            ItemId = itemID;
            StudentId = studentID;
            Name = name;
            Category = category;
            RentPerDay = rentPerDay;
            ItemImage = itemImage;
            this.NoOfRentDays = NoOfRentDays;
            TotalPrice = TotalRentCost;
        }
    }
}
