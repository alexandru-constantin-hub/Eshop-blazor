// <auto-generated />
using Eshop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eshop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Eshop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            ImageUrl = "ImageUrl1",
                            Price = 9.99m,
                            Title = "Title 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            ImageUrl = "ImageUrl2",
                            Price = 9.99m,
                            Title = "Title 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            ImageUrl = "ImageUrl3",
                            Price = 9.99m,
                            Title = "Title 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description 4",
                            ImageUrl = "ImageUrl4",
                            Price = 9.99m,
                            Title = "Title 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
