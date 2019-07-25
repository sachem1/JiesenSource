using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Jiesen.DapperPoco;
using Jiesen.DapperPoco.Adapters;
using MySql.Data.MySqlClient;

namespace Jiesen.ConsoleApp
{
    public class TestDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseConnectionString("");
            //optionsBuilder.UseSqlAdapter(new SqlServerAdapter(SqlClientFactory.Instance));
            optionsBuilder.UseSqlAdapter(new MySqlAdapter(MySqlClientFactory.Instance));
        }
    }
}
