namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieProjectDbContext : DbContext
    {
        public MovieProjectDbContext()
            : base("name=MovieProject")
        {
        }

        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Ads> Ads { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Footers> Footers { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuType> MenuType { get; set; }
        public virtual DbSet<MovieCategory> MovieCategory { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsTag> NewsTag { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Slides> Slides { get; set; }
        public virtual DbSet<SystemConfigs> SystemConfigs { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Trailers> Trailers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Ads>()
                .Property(e => e.NameAds)
                .IsUnicode(false);

            modelBuilder.Entity<Ads>()
                .Property(e => e.ImageAds)
                .IsUnicode(false);

            modelBuilder.Entity<Ads>()
                .Property(e => e.UrlAds)
                .IsUnicode(false);

            modelBuilder.Entity<Ads>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Ads>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Ads>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.NameCategory)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Comments>()
                .Property(e => e.Content)
                .IsFixedLength();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Footers>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Footers>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<MenuType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<MovieCategory>()
                .Property(e => e.NameCategory)
                .IsUnicode(false);

            modelBuilder.Entity<MovieCategory>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MovieCategory>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<MovieCategory>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Movies>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Actor)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Directors)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.MovieLink)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.TrailerLink)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Movies>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<News>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.MovieLink)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.TrailerLink)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.MetaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<NewsTag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Permissions>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Slides>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Slides>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfigs>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfigs>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Trailers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Trailers>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Trailers>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
