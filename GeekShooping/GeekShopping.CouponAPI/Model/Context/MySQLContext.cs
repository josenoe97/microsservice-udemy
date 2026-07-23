using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CouponAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 1,
                CouponCode = "10OFF",
                DiscountAmount = 10,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 2,
                CouponCode = "EURUDIO_2022_10",
                DiscountAmount = 10,
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = 3,
                CouponCode = "EURUDIO_2022_15",
                DiscountAmount = 15,
            });
        }
    }
}
