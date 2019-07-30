using Microsoft.EntityFrameworkCore;

namespace Jiesen.EntityFramework.Core
{
    public class JiesenDbContext : DbContext
    {

        //public JiesenDbContext() : base(nameOrConnectionString:"Data Source =.; Initial Catalog = Develop; User ID = sa; Password=sa1230.;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        //{
        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<JiesenDbContext>());
        //}
        //public DbSet<Student> Students { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Properties().Where(x => x.Name == "Id").Configure(s => s.IsKey());
        //    modelBuilder.Conventions.Add(new Datetime2Convention());

        //    modelBuilder.Properties()
        //        .Where(x => x.GetCustomAttributes(false).OfType<IsUnicode>().Any())
        //        .Configure(c => c.IsUnicode(c.ClrPropertyInfo.GetCustomAttribute<IsUnicode>().Unicode));

        //    modelBuilder.Types().Configure(x => x.ToTable(GetTable(x.ClrType)));
        //}

       
    }


   
}
