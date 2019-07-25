﻿using System.Reflection;

namespace Jiesen.DapperPoco.Metadata
{
    public class EntityColumnInfo
    {
        public PropertyInfo Property { get; set; }
        public string ColumnName { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsAutoIncrement { get; set; }
        public bool IsIgnore { get; set; }

        public void SetValue(object entity, object value)
        {
            Property.SetValue(entity, System.Convert.ChangeType(value, Property.PropertyType));
        }
    }
}
