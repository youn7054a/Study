using System.ComponentModel.DataAnnotations;

namespace SHOP.Model
{
    public partial class User
    {

        [Key]
        public int UserNo { get; set; }
        public string UserID { get; set; }

        public string Name { get; set; }

        public string KeepLogin { get; set; }
        public string Password { get; set; }
        public string Facebook { get; set; }

        public string InsDt { get; set; }

        public string UpdDt { get; set; }

    }
}
