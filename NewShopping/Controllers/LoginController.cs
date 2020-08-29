using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHOP.DAL;
using SHOP.Model;

namespace ZNewShopping.Controllers
{
    public class LoginController : Controller
    {

        public class OutLoginInfo
        {
            public string email { get; set; }
        }
        public class ReturnUrl
        {
            public string url { get; set; }
        }
        public IActionResult Login()
        {
            string returnUrl = HttpContext.Request.Headers["Referer"];
            HttpContext.Response.Cookies.Append("returnUrl", returnUrl);

            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {

            var returnUrl = HttpContext.Request.Cookies["returnUrl"];

            using (var db = new ShopDBContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID.Equals(model.UserID) && u.Password.Equals(model.Password));

                if (user == null)
                {
                    ModelState.AddModelError("LoginError", "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
                }
                else
                {
                    HttpContext.Session.SetInt32("Login_User", user.UserNo);
                    return Redirect(returnUrl);
                }
            }
            return View(model);
        }

        public IActionResult Resister()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Resister(User model)
        {
            using (var db = new ShopDBContext())
            {
                db.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Shop", "Home");
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Login_User");
            return RedirectToAction("Shop", "Home");
        }

        [HttpPost]
        public IActionResult OutLogin([FromBody]OutLoginInfo info)
        {

            var returnUrl = HttpContext.Request.Cookies["returnUrl"];

            using (var db = new ShopDBContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID.Equals(info.email));

                if (user == null)
                {
                    user = new User()
                    {
                        UserID = info.email,
                        Facebook = "Y"
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                user = db.Users.FirstOrDefault(u => u.UserID.Equals(info.email));

                HttpContext.Session.SetInt32("Login_User", user.UserNo);

                ReturnUrl rUrl = new ReturnUrl { url = returnUrl };

                return Json(rUrl);

                //return Ok(Json(new {url = returnUrl }));

            }

        }
    }

}
