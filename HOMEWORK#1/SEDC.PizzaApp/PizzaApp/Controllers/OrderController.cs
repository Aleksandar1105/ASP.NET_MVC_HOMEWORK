using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;
using System.Net;

namespace PizzaApp.Controllers
{
    //[Route("Order")]
    public class OrderController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Order/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Order order = OrderListDb.Orders.FirstOrDefault(o => o.OrderId == id);

            return View(order);
        }

        [Route("Order/JsonData")]
        public IActionResult GetJson()
        {
            Pizza pizza = new Pizza()
            {
                Id = 1,
                Name = "QuattroFormaggi",
                Price = 600,
                IsOnPromotion = false,
                ImageUrl = @"https://hips.hearstapps.com/hmg-prod/images/classic-cheese-pizza-recipe-2-64429a0cb408b.jpg?crop=0.6666666666666667xw:1xh;center,top&resize=1200:*"
            };

            return new JsonResult(pizza);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
