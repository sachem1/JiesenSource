﻿using System;
using System.Collections.Generic;

namespace Jiesen.DapperPoco.Internal
{
    /// <summary>
    /// SQL生成器
    /// </summary>
    public interface ISqlGenerater
    {
        string Insert(Type type, string tableName = null);
        /// <summary>
        /// 根据列删除，列传null表示主键
        /// </summary>
        string DeleteByColumns(Type type, string tableName, ICollection<string> columnNames);
        string Update(Type type, string tableName = null, ICollection<string> columns = null, string primaryKeyName = null);
        string GetAll(Type type, string tableName = null);
        string GetByColumns(Type type, ICollection<string> columnNames, string tableName);
    }
}
