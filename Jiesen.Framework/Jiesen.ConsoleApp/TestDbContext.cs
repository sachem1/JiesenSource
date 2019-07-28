using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Jiesen.Contract.Entitys;
using Jiesen.DapperPoco;
using Jiesen.DapperPoco.Adapters;
using MySql.Data.MySqlClient;

namespace Jiesen.ConsoleApp
{
    public class TestDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseConnectionString("Data Source=.;Initial Catalog=Develop;User ID=sa;Password=sa1230.;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseSqlAdapter(new SqlServerAdapter(SqlClientFactory.Instance));
            //optionsBuilder.UseSqlAdapter(new MySqlAdapter(MySqlClientFactory.Instance));
        }

        public override void OnEntitiesBuilding(EntitiesBuilder entityBuilder)
        {
            entityBuilder.Entity<Student>().TableName("Student");
        }
    }
}
