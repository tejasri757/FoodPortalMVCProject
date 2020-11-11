using FoodPortalMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPortalMVCProject.Controllers
{
    [RoutePrefix("Foodie")]
    public class FoodieController : Controller
    {
            private ApplicationDbContext dbContext = null;
            public FoodieController()
            {
                dbContext = new ApplicationDbContext();
            }
            protected override void Dispose(bool disposing)
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                }
                base.Dispose(disposing);
            }
            // GET: Food
            public ActionResult Index()
            {
                List<Foods> foods = GetFood();

                return View(foods);
            }

            [NonAction]

            public List<Foods> GetFood()
            {
                return dbContext.Foods.ToList();

            }
    }
}