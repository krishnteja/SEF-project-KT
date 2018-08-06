using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PizzaDeliveryWebApplication.Models
{
    
    public class MenuModel
    {
        public List<ItemModel> Items;

    }

    public class ItemModel
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemImageUrl { get; set; }

        public string Ingredients { get; set; }

        public double ItemPrice { get; set; }

        public int Quantity { get; set; }

        public ItemModel()
        {
            ItemId = 0;
            ItemName = string.Empty;
            ItemImageUrl = string.Empty;
            Ingredients = string.Empty;
            ItemPrice = 0;
            Quantity = 0;
        }

        public ItemModel(int id, string name, string url, string ingredients, double price)
        {
            ItemId = id;
            ItemName = name;
            ItemImageUrl = url;
            Ingredients = ingredients;
            ItemPrice = price;
            Quantity = 1;
        }

        public void AddQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}