using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymFit.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<CategoryDetail> CategoryDetails { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category
            {

                CategoryId = 1,
                Name = "Clothings",
                Image = "/Images/Clothing.jpg",
                
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {

                CategoryId = 2,
                Name = "FootWears",
                Image = "/Images/Footwear.jpg",

            });


            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = 3,
                Name = "Equipments",
                Image = "/Images/equipments.jpg",

            });

            modelBuilder.Entity<Category>().HasData(new Category
            {

                CategoryId = 4,
                Name = "Suppliments",
                Image = "/Images/Suppliment.jpg",

            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {

                SubCategoryId = 1,
                Name = "Men"
            });
            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {

                SubCategoryId = 2,
                Name = "Women"
            });
            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {

                SubCategoryId = 3,
                Name = "Weights/Dumbbells"
            });
            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {

                SubCategoryId = 4,
                Name = "Fitness Equipment"
          
            });

            modelBuilder.Entity<SubCategory>().HasData(new SubCategory
            {

                SubCategoryId = 5,
                Name = null

            });
            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 1,
                SubCategoryId = 1,
                CategoryId = 1,
               

            });


            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 2,
                SubCategoryId = 2,
                CategoryId = 1,


            });
            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 3,
                SubCategoryId = 1,
                CategoryId = 2,


            });
            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 4,
                SubCategoryId = 2,
                CategoryId = 2,


            });
            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 5,
                SubCategoryId = 3,
                CategoryId = 3,


            });
            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 6,
                SubCategoryId = 4,
                CategoryId = 3,


            });

            modelBuilder.Entity<CategoryDetail>().HasData(new CategoryDetail
            {

                CategoryDetailId = 7,
                SubCategoryId = 5,
                CategoryId = 4,


            });

            modelBuilder.Entity<Product>().HasData(new Product
            {

                ProductId = 1,
                Name = "Dumb bells",
                Sale = false,
                IsFrontPageProduct = true,


            });
            modelBuilder.Entity<Product>().HasData(new Product
            {

                ProductId = 2,
                Name = "Whey Protien 100%",
                Sale = false,
                IsFrontPageProduct = false,
                Safety = "May contain- Gluten, Egg, Nuts and Peanuts.",
                Ingredient = "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase," +
                 " Beta-D-Galactosidase, Lipase)",
                Description = " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to your" +
            "favourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .",


                Brand = "WHEY",
          


            });

            modelBuilder.Entity<Product>().HasData(new Product
            {

                ProductId = 3,
                Name = "Whey Protien 50%",
                Sale = false,
                IsFrontPageProduct = false,
                Safety = "May contain- Gluten, Egg, Nuts and Peanuts.",
                Ingredient = "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase," +
                 " Beta-D-Galactosidase, Lipase)",
                Description = " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to your" +
            "favourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .",


                Brand = "WHEY",

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {

                ProductId = 4,
                Name = "Decline BenchPress",
                Sale = false,
                IsFrontPageProduct = true,


            });


            modelBuilder.Entity<ProductDetail>().HasData(new ProductDetail
            {

                StockAmount = 2000,
                Price = 120,
                PreviousPrice = 240,
                ProductId = 1,
                ProductDetailId = 1,
                CategoryDetailId = 5
               


            });

            modelBuilder.Entity<ProductDetail>().HasData(new ProductDetail
            {

                StockAmount = 2000,
                Price = 40,
                PreviousPrice = 84,
                ProductId = 3,
                Size = "2.5kg",
                Flavour = "Extreme Chocolate",
                ProductDetailId = 2,
                CategoryDetailId = 7,
          



            });
            modelBuilder.Entity<ProductDetail>().HasData(new ProductDetail
            {
                StockAmount = 2000,
                Price = 20,
                PreviousPrice = 324,
                ProductId = 3,
                Size = "1.5kg",
                Flavour = "Extreme Chocolate",
                ProductDetailId = 3,
                CategoryDetailId = 7,



            });
            modelBuilder.Entity<ProductDetail>().HasData(new ProductDetail
            {

                StockAmount = 2000,
                Price = 40,
                PreviousPrice = 84,
                ProductId = 2,
                Size= "2.5kg",
                Flavour = "Vanilla Chocolate",
                ProductDetailId = 4,
                CategoryDetailId = 7,



            });
            modelBuilder.Entity<ProductDetail>().HasData(new ProductDetail
            {

                StockAmount = 2000,
                Price = 20,
                PreviousPrice = 324,
                ProductId = 2,
                Size= "1.5kg",
                Flavour = "Vanilla Chocolate",
                ProductDetailId = 5,
                CategoryDetailId = 7,


            });
            modelBuilder.Entity<ProductDetail>().HasData(new ProductDetail
            {
                StockAmount = 2000,
                Price = 120,
                PreviousPrice = 240,
                ProductId = 4,
                ProductDetailId = 6,
                CategoryDetailId = 6,




            });


            modelBuilder.Entity<Image>().HasData(new Image
            {
                ImageId = 1,
                ProductDetailId = 1,
                Url = "/productimages/dumbbell1.png"

            });
            modelBuilder.Entity<Image>().HasData(new Image
            {
                ImageId = 2,
                ProductDetailId = 6,
                Url = "/productimages/decline-benchpress.png"

            });
            modelBuilder.Entity<Image>().HasData(new Image
            {
                ImageId = 3,
                ProductDetailId = 2,
                Url = "/productimages/whey.jpg"
            });
           

            modelBuilder.Entity<Image>().HasData(new Image
            {
                ImageId = 4,
                ProductDetailId = 3,
                Url = "/productimages/bigwhey.png"

            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                ImageId = 5,
                ProductDetailId = 5,
                Url = "/productimages/whey.jpg"
            });

            modelBuilder.Entity<Image>().HasData(new Image
            {
                ImageId = 6,
                ProductDetailId = 4,
                Url = "/productimages/bigwhey.png"

            });


        }


    }
}
