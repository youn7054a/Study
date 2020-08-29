using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SHOP.DAL;
using SHOP.Model;
using ZNewShopping.Views.VIewModel;

namespace ZNewShopping.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Check()
        {
            using (var db = new ShopDBContext())
            {
                var userNo = HttpContext.Session.GetInt32("Login_User");
                
                var checkout = db.Checkouts.FirstOrDefault(c => c.UserNo == userNo);

                var shipInfo = db.ShipInfos.FirstOrDefault(c => c.UserNo == userNo);


                Carts carts = new Carts
                {

                    CartLine = db.Carts
                                 .Where(c => c.UserNo == userNo)
                                 .Include(u => u.Product)
                                 .ToList()
                };

                return View(new ViewModelCheck { Checkout = checkout, ShipInfo = shipInfo, Carts = carts });
            }
            
        }
    }
}
