using SHOP.Model;
using System.Collections.Generic;

namespace SHOP.IDAL
{
    public interface IProductDAL
    {
        List<Product> GetProductList();
        void CreateProduct(Product product);
        void DeleteProduct(Product product);

        void UpdateProduct(Product product);

        List<CommonCode1> GetCom1List();

        List<CommonCode2> GetCom2List(string code1);
    }
}
