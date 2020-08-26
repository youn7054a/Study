using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ComModel;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RestSharp;
using SHOP.DAL;
using SHOP.Model;

namespace ZNewShopping.Controllers
{
    public class CartController : Controller
    {
        private readonly IConfiguration _configuration;

        public CartController(IConfiguration configuration)
        {

            _configuration =    configuration;

        }
        
        [HttpPost]
        public async Task<IActionResult> AddtoCart(string item_qty, string item_code, string item_cost)
        {
            //1.로그인 했을 경우

            //2. 장바구니에 담았을 경우
            Guid g = Guid.NewGuid();

            if (HttpContext.Session.GetInt32("Login_User") == null)
            {
                HttpContext.Session.SetInt32("Login_User", 1000000);//비회원처리 구현해야함
            }

            var param = new DynamicParameters();
            param.Add("Code", item_code);
            param.Add("Count", item_qty);
            param.Add("UserNo", HttpContext.Session.GetInt32("Login_User"));

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                db.Open();

                //results = db.Query<dynamic>("SHO_PROC_PAGE", param, commandType: CommandType.StoredProcedure);
                await db.ExecuteAsync("SHO_PROC_CART_INSERT", param, commandType: CommandType.StoredProcedure).ConfigureAwait(false);

                return RedirectToAction("Shop", "Home");
            }

        }

        [HttpPost]
        public  IActionResult DeletetoCart([FromBody]Cart cart)
        {
            using (var db = new ShopDBContext())
            {
                var vcart = db.Carts.FirstOrDefault(c => c.UserNo.Equals(cart.UserNo) && c.Code.Equals(cart.Code));

                if (vcart == null)
                {
                    return StatusCode(404);
                }
                else
                {
                    db.Carts.Remove(vcart);
                    db.SaveChanges();

                    return Json(new { success = true });
                }
            }


        }

        public IActionResult Cart()
        {
            string returnUrl = HttpContext.Request.Headers["Referer"];

            if (HttpContext.Session.GetInt32("Login_User") == null)
            {
                return View();
            }

            var param = new DynamicParameters();
            
            param.Add("UserNo", HttpContext.Session.GetInt32("Login_User"));

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                db.Open();

                //results = db.Query<dynamic>("SHO_PROC_PAGE", param, commandType: CommandType.StoredProcedure);
                IEnumerable<dynamic> results = db.Query<dynamic>("SHO_PROC_CART_SELECT", param, commandType: CommandType.StoredProcedure);

                ViewBag.userNo = HttpContext.Session.GetInt32("Login_User");
                return View(results);
            }
        }
    }
}
