using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Practice1.Models
{
    public partial class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Cid { get; set; }

        public virtual Customer C { get; set; }
    }
}
