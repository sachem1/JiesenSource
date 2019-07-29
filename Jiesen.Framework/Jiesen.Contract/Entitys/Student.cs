using System;
using System.Collections.Generic;
using System.Text;
using Jiesen.Common.Attribute;

namespace Jiesen.Contract.Entitys
{
    public class Student : BaseEntity
    {
        [IsUnicode(true)]
        public string Name { get; set; }
    }
}
