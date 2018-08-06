using PizzaDeliveryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PizzaDeliveryWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private CartModel cartModel;

       [Authorize]
        public ActionResult Index()
        {
            MenuDomainModel menu = new MenuDomainModel();
            MenuModel model;
            model=menu.GetItems();
            return View(model);
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "A family-owned Pizza Company.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us at the below address.";

            return View();
        }

        [Authorize]
        public ActionResult Cart()
        {
            ViewBag.Message = "This is your Cart!";
            if (cartModel == null)
                cartModel = new CartModel { SelectedItems = new List<ItemModel>() };
            cartModel = (CartModel)Session["CartModel"];

            Session["CartModel"] = cartModel;
            return View(cartModel);
        }
       
        [ActionName("CartById")]
        public ActionResult Cart(int itemId)
        {
             bool itemFound = false;
            MenuDomainModel menu = new MenuDomainModel();   
            ItemModel item =  menu.GetItem(itemId);
            ViewBag.Message="You have added "+item.ItemName;
           
            cartModel = (CartModel)Session["CartModel"];
            if (cartModel == null)
                cartModel = new CartModel { SelectedItems = new List<ItemModel>() };
            foreach(ItemModel modelItem in cartModel.SelectedItems.ToList())
            {               
               if(itemId==modelItem.ItemId)
                {
                    var toUpdate = cartModel.SelectedItems.FirstOrDefault(s => s.ItemId == itemId);
                    toUpdate.AddQuantity(Convert.ToInt32(modelItem.Quantity)+1);
                    itemFound = true;
                    break;
                }              
            }

            if(!itemFound)
            cartModel.SelectedItems.Add(item);
            Session["CartModel"] = cartModel;
            return View("Cart",cartModel);
        }        

        public ActionResult ConfirmOrder(string quan1 = "-1",
        string quan2 = "-1", string quan3 = "-1", string quan4 = "-1", string total="0")
        {
            SaveOrderLocal(quan1, quan2, quan3, quan4, total);
            OrderDomainModel orderDomain = new OrderDomainModel();
            int orderId= orderDomain.SaveOrder(cartModel, User.Identity.Name);
            OrderModel orderModel = orderDomain.GetUserOrder(orderId);
            cartModel = null;
            Session["CartModel"] = null;
            return View("ConfirmOrder", orderModel);
        }
        
        public ActionResult SaveOrder(string quan1 = "-1",
            string quan2 = "-1", string quan3 = "-1", string quan4 = "-1", string total = "0")
        {
            SaveOrderLocal(quan1, quan2, quan3, quan4, total);
            return View("Cart", cartModel);
        }          

        private void SaveOrderLocal(string quan1, string quan2, string quan3, string quan4, string total)
        {
            cartModel = (CartModel)Session["CartModel"];
            if (cartModel == null)
                cartModel = new CartModel { SelectedItems = new List<ItemModel>() };
            else
            {
                foreach (ItemModel item in cartModel.SelectedItems.ToList())
                {
                    switch (item.ItemId)
                    {
                        case 1:
                            if (int.Parse(quan1) > 0)
                            {
                                var toUpdate = cartModel.SelectedItems.FirstOrDefault(s => s.ItemId == item.ItemId);
                                toUpdate.AddQuantity(Convert.ToInt32(quan1));
                            }
                            else if (int.Parse(quan1) == 0)
                            {
                                cartModel.SelectedItems.RemoveAll(s => s.ItemId == item.ItemId);
                            }
                            break;
                        case 2:
                            if (int.Parse(quan2) > 0)
                            {
                                var toUpdate = cartModel.SelectedItems.FirstOrDefault(s => s.ItemId == item.ItemId);
                                toUpdate.AddQuantity(Convert.ToInt32(quan2));
                            }
                            else if (int.Parse(quan2) == 0)
                            {
                                cartModel.SelectedItems.RemoveAll(s => s.ItemId == item.ItemId);
                            }
                            break;
                        case 3:
                            if (int.Parse(quan3) > 0)
                            {
                                var toUpdate = cartModel.SelectedItems.FirstOrDefault(s => s.ItemId == item.ItemId);
                                toUpdate.AddQuantity(Convert.ToInt32(quan3));
                            }
                            else if (int.Parse(quan3) == 0)
                            {
                                cartModel.SelectedItems.RemoveAll(s => s.ItemId == item.ItemId);
                            }
                            break;
                        case 4:
                            if (int.Parse(quan4) > 0)
                            {
                                var toUpdate = cartModel.SelectedItems.FirstOrDefault(s => s.ItemId == item.ItemId);
                                toUpdate.AddQuantity(Convert.ToInt32(quan4));
                            }
                            else if (int.Parse(quan4) == 0)
                            {
                                cartModel.SelectedItems.RemoveAll(s => s.ItemId == item.ItemId);
                            }
                            break;

                        default:
                            break;
                    }
                }

                cartModel.totalAmount = Convert.ToDouble(total);

                Session["CartModel"] = cartModel;
            }
        }

    }
}