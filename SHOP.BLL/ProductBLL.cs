using SHOP.IDAL;
using SHOP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SHOP.BLL 
{

    public class ProductBLL
    {
        private IProductDAL _productDAL;

        public ProductBLL(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetProductList()
        {
            return _productDAL.GetProductList();
        }

        public void CreateProduct(Product product)
        {
            _productDAL.CreateProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            _productDAL.DeleteProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _productDAL.UpdateProduct(product);
        }

        public List<CommonCode1> GetCom1List()
        {
            return _productDAL.GetCom1List();
        }

        public List<CommonCode2> GetCom2List(string code1)
        {
            return _productDAL.GetCom2List(code1);
        }
    }
}
