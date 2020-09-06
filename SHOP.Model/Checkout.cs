using System.ComponentModel.DataAnnotations;

namespace SHOP.Model
{
    public partial class Checkout
    {

        [Key]
        public int UserNo { get; set; }
        public int Seq { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Zipcode { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public string Message { get; set; }
        public decimal TotalAmt { get; set; }


    }
}
