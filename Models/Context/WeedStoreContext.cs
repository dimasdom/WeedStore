using WeedStore.Models.User;
using WeedStore.Models.Goods;
using Microsoft.EntityFrameworkCore;
using WeedStore.Models.Order;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WeedStore.Models.Context
{
    public class WeedStoreContext:IdentityDbContext<UserModel>
    {
        public WeedStoreContext(DbContextOptions<WeedStoreContext> options): base(options)
        {
        }

        public DbSet<GoodsModel> Goods { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
    }
}
