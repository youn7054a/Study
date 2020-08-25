using ComModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SHOP.Model
{
    public  class Cart
    {
        [Key]
        [Column(Order = 2)]
        public string Code { get; set; }
        public decimal Count { get; set; }
        [Key]
        [Column(Order = 1)]
        public int UserNo { get; set; }
    }
}
