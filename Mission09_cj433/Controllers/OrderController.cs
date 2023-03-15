using Microsoft.AspNetCore.Mvc;
using Mission09_cj433.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cj433.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repo { get; set; }
        private Basket basket { get; set; }

        public OrderController(IOrderRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your basket is empty!");
            }

            if (ModelState.IsValid)
            {
                order.Lines = basket.Items.ToArray();
                repo.SaveOrder(order);
                basket.ClearBasket();

                return RedirectToPage("/OrderCompleted");
            }
            else
            {
                return View();
            }
        }
    }
}