using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Text;
using System.Text.RegularExpressions;

namespace Jiesen.EntityFramework
{
    public class Extend
    {
        public string GetTable(Type type)
        {
            var pluralizationService= DbConfiguration.DependencyResolver.GetService<IPluralizationService>();
            var result = pluralizationService.Pluralize(type.Name);
            result = Regex.Replace(result, ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);

            return result.ToLower();
        }
    }

     
}
