﻿
using System;
using Jiesen.DapperPoco.Adapters;

namespace Jiesen.DapperPoco
{
    public class DbContextOptions
    {
        public DbContextOptions(string connectionString, ISqlAdapter sqlAdapter)
        {
            ConnectionString = connectionString;
            SqlAdapter = sqlAdapter;
        }

        public string ConnectionString { get; }
        public ISqlAdapter SqlAdapter { get; }

        internal static IServiceProvider Services { get; set; }
    }
}
