using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Practice1.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
