using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeedStore.Models.Goods;
using WeedStore.Models.Order;
using WeedStore.Models.User;

namespace WeedStore.Models.Context
{
    public class WeedStoreContext : IdentityDbContext<UserModel>
    {
        public WeedStoreContext(DbContextOptions<WeedStoreContext> options) : base(options)
        {
        }

        public DbSet<GoodsModel> Goods { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
    }
}
