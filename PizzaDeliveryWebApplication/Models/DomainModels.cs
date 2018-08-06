using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace PizzaDeliveryWebApplication.Models
{
    /// <summary>
    /// domain model for User object
    /// </summary>
    public class UserDomainModel
    {
        /// <summary>
        /// connection string for database
        /// </summary>
        string connStr = ConfigurationManager.ConnectionStrings["AppDatabaseConnection"].ConnectionString;

        /// <summary>
        /// method that return userid bases on email
        /// </summary>
        /// <param name="email">email address</param>
        /// <returns>userid field</returns>
        public int GetUserId(string email)
        {
            int userId = -1;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "GetUserIdByEmail";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@Email", email));

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userId = Convert.ToInt32(reader["UserId"]);
                }

                cmd.Parameters.Clear();
                cmd.Dispose();
            }

            return userId;
        }

        /// <summary>
        /// adds a user object
        /// </summary>
        /// <param name="user">usermodel object</param>
        public void AddUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "AddUser";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@Name", user.Name));
                cmd.Parameters.Add(new SqlParameter("@Email", user.Email));
                cmd.Parameters.Add(new SqlParameter("@Password", user.Password));
                cmd.Parameters.Add(new SqlParameter("@AddressLine1", user.Line1));
                cmd.Parameters.Add(new SqlParameter("@AddressLine2", user.Line2));
                cmd.Parameters.Add(new SqlParameter("@City", user.City));
                cmd.Parameters.Add(new SqlParameter("@State", user.State));
                cmd.Parameters.Add(new SqlParameter("@Country", user.Country));
                cmd.Parameters.Add(new SqlParameter("@ZipCode", user.ZipCode));
                int result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
            }
        }

        /// <summary>
        /// gets user info based on email address
        /// </summary>
        /// <param name="userName">email of the user</param>
        /// <returns>usermodel object</returns>
        public UserModel GetUserInfo(string userName)
        {
            UserModel user = null;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "GetUserByEmail";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@Email", userName));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user = new UserModel();
                        user.UserId = Convert.ToInt32(reader["UserId"]);
                        user.Name = Convert.ToString(reader["Name"]);
                        user.Email = Convert.ToString(reader["Email"]);
                        user.Password = Convert.ToString(reader["Password"]);
                        user.Line1 = Convert.ToString(reader["AddressLine1"]);
                        user.Line2 = Convert.ToString(reader["AddressLine2"]);
                        user.City = Convert.ToString(reader["City"]);
                        user.Country = Convert.ToString(reader["Country"]);
                        user.ZipCode = Convert.ToString(reader["ZipCode"]);
                        user.State = Convert.ToString(reader["State"]);
                    }
                }

                cmd.Parameters.Clear();
                cmd.Dispose();
            }

            return user;
        }
    } 

    /// <summary>
    /// domain model for menu object
    /// </summary>
    public class MenuDomainModel
    {
        /// <summary>
        /// connection string for database
        /// </summary>
        string connStr = ConfigurationManager.ConnectionStrings["AppDatabaseConnection"].ConnectionString;

        /// <summary>
        /// method that returns an itemviewmodel object
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <returns>itemviewmodel object</returns>
        public ItemModel GetItem(int id)
        {
            MenuModel model = GetItems();
            var item = model.Items.FirstOrDefault(x => x.ItemId == id);
            return item;
        }

        /// <summary>
        /// method that returns all items of the menu
        /// </summary>
        /// <returns>menumodel object</returns>
        public MenuModel GetItems()
        {
            MenuModel model = new MenuModel() { Items = new List<ItemModel>() };
            ItemModel item;
            int id;
            string name;
            string url;
            string ingredients;
            double price;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "GetAllItems";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader[0]);
                    name = Convert.ToString(reader[1]);
                    url = Convert.ToString(reader[2]);
                    ingredients = Convert.ToString(reader[3]);
                    price = Convert.ToDouble(reader[4]);
                    item = new ItemModel(id, name, url, ingredients, price);
                    model.Items.Add(item);
                }

                cmd.Dispose();
            }

            return model;
        }
    }

    /// <summary>
    /// Domain model for order object
    /// </summary>
    public class OrderDomainModel
    {
        /// <summary>
        /// connection string for database
        /// </summary>
        string connStr = ConfigurationManager.ConnectionStrings["AppDatabaseConnection"].ConnectionString;

        /// <summary>
        /// Returns Order object of the user
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <returns>ordermodel object</returns>
        public OrderModel GetUserOrder(int orderId)
        {
            OrderModel order = new OrderModel();
            order.Items = new List<ItemModel>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "GetOrderItemsById";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@OrderId", orderId));
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    order.OrderId = Convert.ToInt32(reader[0]);
                    order.OrderAmount = Convert.ToDouble(reader[1]);
                    ItemModel item = new ItemModel();
                    item.ItemId = Convert.ToInt32(reader[2]);
                    item.ItemName = Convert.ToString(reader[3]);
                    item.ItemImageUrl = Convert.ToString(reader[4]);
                    item.Ingredients = Convert.ToString(reader[5]);
                    item.ItemPrice = Convert.ToDouble(reader[6]);
                    item.Quantity = Convert.ToInt32(reader[7]);
                    order.Items.Add(item);
                }

                cmd.Dispose();
            }
            return order;
        }

        /// <summary>
        /// saves an cartmodel object
        /// </summary>
        /// <param name="cart">cart model</param>
        /// <param name="name">name</param>
        /// <returns></returns>
        public int SaveOrder(CartModel cart, string name)
        {
            Random nbr = new Random();
            int orderId = nbr.Next();
            double total = 0;
            foreach (ItemModel item in cart.SelectedItems.ToList())
            {
                SaveOrderItem(orderId, item.ItemId, item.Quantity);
                total = total + (item.ItemPrice * item.Quantity);
            }

            UserDomainModel user = new UserDomainModel();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "AddUserOrders";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@OrderId", orderId));
                cmd.Parameters.Add(new SqlParameter("@UserId", user.GetUserId(name)));
                cmd.Parameters.Add(new SqlParameter("@OrderAmount", total));
                int result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
            }

            return orderId;
        }

        public void SaveOrderItem(int orderId, int itemId, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlStr = "AddOrderItems";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@OrderId", orderId));
                cmd.Parameters.Add(new SqlParameter("@ItemId", itemId));
                cmd.Parameters.Add(new SqlParameter("@ItemQuantity", quantity));
                int result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
            }
        }
    }
}