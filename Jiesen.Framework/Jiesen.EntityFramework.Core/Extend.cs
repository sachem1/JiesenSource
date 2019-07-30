using Microsoft.Extensions.Configuration;
using System;
using System.Text.RegularExpressions;

namespace Jiesen.EntityFramework.Core
{
    public class Extend
    {
        //public string GetTable(Type type)
        //{
        //    var pluralizationService= IConfiguration.DependencyResolver.GetService<IPluralizationService>();
        //    var result = pluralizationService.Pluralize(type.Name);
        //    result = Regex.Replace(result, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);

        //    return result.ToLower();
        //}
    }
    //public class Datetime2Convention : Convention
    //{
    //    public Datetime2Convention()
    //    {
    //        this.Properties<DateTime>().Configure(d => d.HasColumnType("datetime2"));
    //    }
    //}

}
