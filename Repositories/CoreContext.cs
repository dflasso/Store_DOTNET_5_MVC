using Microsoft.EntityFrameworkCore;
using G10COMERCIALIZADORA_DOTNET.Models;

namespace G10COMERCIALIZADORA_DOTNET.Repositories
{
    public class CoreContext : DbContext
    {
        public DbSet<UserApp> Users { get; set; }
        public DbSet<HomeAddress> homeAddresses {get; set;}
        public DbSet<KeysApp> keys {get; set;}
        public DbSet<States> states {get; set;}
        public DbSet<StatesOfUser> statesOfUsers {get; set;}
        public DbSet<Configurations> configurations {get; set;}
        public DbSet<Permissions> permissions {get; set;}
        public DbSet<PermissonsOfProfile> permissonsOfProfiles {get; set;}
        public DbSet<Profile> profiles {get; set;}
        public DbSet<UserProfile> userProfiles {get; set;}

        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {

        }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            UsersDefaultData.CreateDefaulUsers(modelBuilder);
            ConfigDefaultApp.CreateConfigDefault(modelBuilder);
        }
    }
}