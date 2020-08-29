using ComModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SHOP.Model
{
    public  class Cart
    {

        public decimal Count { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UserNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Code { get; set; }

        public virtual Product Product { get; set; }
    }

    public class Carts
    {
        public List<Cart> CartLine { get; set;}
    }
}
