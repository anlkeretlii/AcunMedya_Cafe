using AcunMedya.Cafe.Entities;

using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace AcunMedya.Cafe.Context
{
    public class CafeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANIL; initial catalog=DbAcunMedyaCafe; integrated Security=true; TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }

    }
}
