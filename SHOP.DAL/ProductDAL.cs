using Microsoft.EntityFrameworkCore;
using SHOP.IDAL;
using SHOP.Model;
using System.Collections.Generic;
using System.Linq;

namespace SHOP.DAL
{
    public class ProductDAL : IProductDAL
    {
        public List<Product> GetProductList()
        {
            using (var db = new ShopDBContext())
            {
                //var pro = db.Products.ToList();
                var pro = db.Products.FromSqlRaw("select code "
                                            + ",(select name from CommonCode1s c where p.ComCode1 = c.CODE1) ComCode1"
                                            + ",(select name from CommonCode2s c where p.ComCode1 = c.CODE1 and p.ComCode2 = c.CODE2) ComCode2"
                                            + ",Name"
                                            + ",Description"
                                            + ",Price"
                                            + " from Products p").ToList();

                
                return pro;
            }
        }
        
        public void CreateProduct(Product product)
        {
            using (var db = new ShopDBContext())
            {
                var prod = db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (var db = new ShopDBContext())
            {
                var prod = db.Products.FirstOrDefault(u => u.Code == product.Code);
                db.Products.Remove(prod);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var db = new ShopDBContext())
            {
                var prod = db.Products.FirstOrDefault(u => u.Code == product.Code);
                prod.Description = product.Description;
                prod.Name = product.Name;
                prod.Price = product.Price;
                db.SaveChanges();
            }
        }

        public List<CommonCode1> GetCom1List()
        {
            using (var db = new ShopDBContext())
            {
                return db.CommonCode1s.ToList();
            }
        }

        public List<CommonCode2> GetCom2List(string code1)
        {
            using (var db = new ShopDBContext())
            {
                return db.CommonCode2s.Where(c=>c.Code1 == code1).ToList();
            }
        }
    }
}
