namespace Eshop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Title 1",
                    Description = "Description 1",
                    ImageUrl = "ImageUrl1",
                    Price = 9.99
                },
                new Product
                {
                    Id = 2,
                    Title = "Title 2",
                    Description = "Description 2",
                    ImageUrl = "ImageUrl2",
                    Price = 9.99
                },
                new Product
                {
                    Id = 3,
                    Title = "Title 3",
                    Description = "Description 3",
                    ImageUrl = "ImageUrl3",
                    Price = 9.99
                },
                new Product
                {
                    Id = 4,
                    Title = "Title 4",
                    Description = "Description 4",
                    ImageUrl = "ImageUrl4",
                    Price = 9.99
                }
         );
        }

        public DbSet<Product> Products { get; set; }
    }
}
