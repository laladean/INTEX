using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class photodata
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string description { get; set; }
        public string filename { get; set; }
        public int? photodataid { get; set; }
        public DateTime? date { get; set; }
        public string url { get; set; }
    }
}
