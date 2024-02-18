using System;
using System.Collections.Generic;

namespace DBConWebApp.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
    }
}
