using System;
using System.Collections.Generic;
using System.Text;

namespace Jiesen.Contract.Models
{
    public class StudentDto:BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
