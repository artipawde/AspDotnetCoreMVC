using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtiShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> orderDetails { get;  set; }
       // public  DbSet<PieGiftOrder> pieGiftOrders { get;  set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category{CategoryId=1, CategoryName="Fruit Cakes", Descripation="All Cheese pie"}
                );
            modelBuilder.Entity<Category>().HasData(
                new Category{CategoryId=2, CategoryName="Chocolate Cakes", Descripation="All Chocolate pie"} 
                );


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId =1, 
                Name="Fruit Cake",
                Price =520.50M, 
                ShortDescription="Only Fruits", 
                LongDescription="A fruitcake is a cake that contains raisins, currants, and other dried fruit. 2. countable noun. If you refer to someone as a fruitcake, you mean that they are crazy or that their behavior is very strange.", 
                CategoryId = 1,
                ImageUrl= "/Image/fruitcake1.jfif", 
                InStock=true, 
                IsPieOfTheWeek=true , 
                ImageThumbnailUrl= "/Image/fruitcake1.jfif"
            }
                );


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Chocolate Pie",
                Price = 240.50M,
                ShortDescription = "Only Cheese",
                LongDescription = "Pudding, or in this case, chocolate pie filling, only requires a few ingredients to make. We start with sugar, egg yolks (you can save the whites for an Angel Food cake or Funfetti cake!), cornstarch (to help firm up the chocolate pie and make it sliceable rather than soupy!), salt, milk, and heavy cream.",
                CategoryId = 2,
                ImageUrl = "/Image/French Silk Pie.png",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "/Image/French Silk Pie.png"
            });

        }
    }
}
