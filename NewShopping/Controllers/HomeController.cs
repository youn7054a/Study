using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NewShopping.Models;
using PagedList.Core;
using SHOP.DAL;
using SHOP.Model;
using ZNewShopping.Views.VIewModel;

namespace NewShopping.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {

            _configuration = configuration;

        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Shop(int pageNo = 1, string code1 = "", string code2 = "")
        {

            IEnumerable<dynamic> results;
            var param = new DynamicParameters();
            int pageCount = 1;
            int remainderPageCount;
            int totalItemCount = 0; //총 아이템갯수
            int pageSize = 9; //노출될 아이템 갯수
            int pageDisplayCount = 5; //표시될 인덱스 갯수
            int startPage;
            int endPage;

            param.Add("PAGENO", pageNo);
            param.Add("PAGESIZE", pageSize);
            param.Add("CODE1", code1);
            param.Add("CODE2", code2);
            param.Add("TOTALCOUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                db.Open();

                //IEnumerable<dynamic> results = db.Query(sql, param);

                results = db.Query<dynamic>("SHO_PROC_PAGE", param, commandType: CommandType.StoredProcedure);

                totalItemCount = param.Get<int>("TOTALCOUNT");

            }

            remainderPageCount = totalItemCount % pageSize;
            pageCount = totalItemCount / pageSize;

            if (remainderPageCount > 0)
            {
                pageCount++;
            }

            if (pageNo > pageCount)
            {
                pageNo = pageCount;
            }

            startPage = pageNo - (pageDisplayCount / 2);
            if (startPage < 1)
                startPage = 1;


            endPage = startPage + (pageDisplayCount - 1);

            if (endPage > pageCount)
                endPage = pageCount;


            ViewBag.startPage = startPage;
            ViewBag.endPage = endPage;
            ViewBag.totalPageNo = pageCount;
            ViewBag.pageNo = pageNo;


            return View(results);

        }

        [HttpGet("{code:int}")]//인라인 제약조건
        public IActionResult ShopDetail(int code)
        {

            //using (var db = new ShopDBContext())
            //{
            //    var product = db.Products.FirstOrDefault(a => a.Code == code);

            //    return View(product);
            //}



            //IEnumerable<dynamic> results;
            Product results;
            var param = new DynamicParameters();

            param.Add("CODE", code);

            using (IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                db.Open();

                //IEnumerable<dynamic> results = db.Query(sql, param);

                results = db.Query<Product>("SHO_PROC_ITEM_DETAIL", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return View(results);
        }
    }
}
