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






        }


    }
}
