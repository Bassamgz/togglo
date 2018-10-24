namespace Togglo.Core.Data
{
    using Microsoft.EntityFrameworkCore;

    public partial class ToggloEntities : DbContext
    {
        public ToggloEntities()
            : base()
        {
        }

        public ToggloEntities(
            DbContextOptions<ToggloEntities> options)
            : base(options)
        {
        }

        public virtual void Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=BEAST\\SQLEXPRESS; Database = eFruit;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }
    }
}
