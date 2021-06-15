using Microsoft.EntityFrameworkCore;
using MultiTenantWidgetApi.Models;

namespace MultiTenantWidgetApi.DataStore
{
    public partial class WidgetDbContext : DbContext
    {
        public WidgetDbContext(DbContextOptions<WidgetDbContext> options) : base(options) { }

       // public WidgetDbContext(string connectionString) : base(GetOptions(connectionString)) { }

        public virtual DbSet<Widget> Widgets { get; set; }

        //public static string ConnectionString
        //{
        //    get;
        //    set;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //if (!optionsBuilder.IsConfigured)    
        //    //{    
        //    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.    
        //    if (!string.IsNullOrEmpty(ConnectionString)) optionsBuilder.UseSqlServer(ConnectionString);
        //    // }    
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           modelBuilder.ApplyConfiguration(new WidgetMap());
        }
    }
}
