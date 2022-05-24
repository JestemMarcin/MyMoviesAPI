using Microsoft.EntityFrameworkCore;

namespace MyMovies.Models
{

    public partial class MyMoviesContext : DbContext
    {


        public MyMoviesContext(DbContextOptions<MyMoviesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionYear).HasColumnName("production_year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
