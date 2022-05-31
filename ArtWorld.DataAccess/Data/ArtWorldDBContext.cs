using ArtWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtWorld.DataAccess.Data
{
    public class ArtWorldDBContext : DbContext
    {
        public ArtWorldDBContext(DbContextOptions<ArtWorldDBContext> options) : base(options) { }

        public DbSet<Anime> Anime { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<AnimeGenre> AnimeGenre { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Anime>(AnimeConfigure);
            builder.Entity<Studio>(StudioConfigure);
            builder.Entity<Genre>(GenreConfigure);
            builder.Entity<AnimeGenre>(AnimeGenreConfigure);
        }

        private void AnimeConfigure(EntityTypeBuilder<Anime> builder)
        {
            builder.ToTable("Anime").Property(p => p.Title).IsRequired().HasMaxLength(255);
            builder.ToTable("Anime").Property(p => p.TitleRomadzi).IsRequired().HasMaxLength(255);
            builder.ToTable("Anime").Property(p => p.Type).HasMaxLength(500);
            builder.ToTable("Anime").Property(p => p.Description).HasMaxLength(1000);
            builder.ToTable("Anime").Property(p => p.Info).HasMaxLength(1000);
            builder.ToTable("Anime").Property(p => p.Image).HasMaxLength(255);
            builder.ToTable("Anime").Property(p => p.Images).HasMaxLength(255);
            builder.ToTable("Anime").Property(p => p.Teaser).HasMaxLength(255);
        }

        private void StudioConfigure(EntityTypeBuilder<Studio> builder)
        {
            builder.ToTable("Studios").Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.ToTable("Studios").HasMany(s => s.Anime).WithOne(a => a.Studio).OnDelete(DeleteBehavior.SetNull);
            builder.ToTable("Studios").HasData(
                    new Studio[]
                    {
                        new Studio { Id = 1, Name = "MadHouse" },
                        new Studio { Id = 2, Name = "Pierrot" }
                    });
        }
        
        private void GenreConfigure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres").Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.ToTable("Genres").HasData(
                    new Genre[]
                    {
                        new Genre { Id= 1, Name = "Боевик" },
                        new Genre { Id = 2, Name = "Приключения" }
                    });
        }
        
        private void AnimeGenreConfigure(EntityTypeBuilder<AnimeGenre> builder)
        {
            builder.ToTable("AnimeGenre").HasKey(ag => new { ag.Id });
            builder.ToTable("AnimeGenre").HasOne(ag => ag.Anime).WithMany(a => a.AnimeGenres).HasForeignKey(ag => ag.AnimeId);
            builder.ToTable("AnimeGenre").HasOne(ag => ag.Genre).WithMany(g => g.AnimeGenres).HasForeignKey(ag => ag.GenreId);
        }
    }
}
