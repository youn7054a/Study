using System.ComponentModel.DataAnnotations;

namespace SHOP.Model
{
    public partial class ShipInfo
    {

        [Key]
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Detail { get; set; }
        public string Zipcode { get; set; }

        public string Phone1 { get; set; }
        public string Phone2 { get; set; }


    }
}
