using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SHOP.Model
{
    public partial class ShipInfo
    {

        [Key]
        public int UserNo { get; set; }
        [AllowNull]
        public string Name { get; set; }
        [AllowNull]
        public string Address { get; set; }
        [AllowNull]
        
        public string Detail { get; set; }
        [AllowNull]
        public string Zipcode { get; set; }

        [AllowNull]
        public string Phone1 { get; set; }
        [AllowNull]
        public string Phone2 { get; set; }


    }
}
