using Microsoft.EntityFrameworkCore;
using SHOP.Model;

namespace SHOP.DAL
{
    public class ShopDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ybj.cdswjv7tloqv.ap-northeast-2.rds.amazonaws.com, 1433;Database=Study;User Id=admin;Password=qjawls23;");
        }

        public virtual DbSet<CommonCode1> CommonCode1s { get; set; }
        public virtual DbSet<CommonCode2> CommonCode2s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Checkout> Checkouts { get; set; }
        public virtual DbSet<ShipInfo> ShipInfos { get; set; }



        //엔티티 프레임워크 멀티키사용
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<CommonCode2>()
                    .HasKey(pc => new
                    {
                        pc.Com1Code1,
                        pc.Com2Code2
                    });

            modelBuilder.Entity<Cart>()
                    .HasKey(pc => new
                    {
                        pc.UserNo,
                        pc.Code
                    });
        }
    }
}
