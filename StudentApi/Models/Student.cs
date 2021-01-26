using System;
using System.Collections.Generic;

#nullable disable

namespace StudentApi.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? Contact { get; set; }
        public string Address { get; set; }
    }
}
