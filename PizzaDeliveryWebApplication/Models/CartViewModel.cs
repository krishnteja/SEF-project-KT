using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaDeliveryWebApplication.Models
{
    /// <summary>
    /// View Model for Cart view
    /// </summary>
    public class CartModel
    {
        /// <summary>
        /// Selected Items list
        /// </summary>
        public List<ItemModel> SelectedItems;

        /// <summary>
        /// total amount field
        /// </summary>
        public double totalAmount { get; set; }

        /// <summary>
        /// cart model constructor
        /// </summary>
        public CartModel()
        {
            SelectedItems = new List<ItemModel>();
            totalAmount = 0;
        }
    }

    /// <summary>
    /// view model for ConfirmOrder view
    /// </summary>
    public class OrderModel
    {
        /// <summary>
        /// orderid field
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// items list in the order
        /// </summary>
        public List<ItemModel> Items;

        /// <summary>
        /// order amount field
        /// </summary>
        public double OrderAmount { get; set; }
    }
}