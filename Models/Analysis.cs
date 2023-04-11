using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class analysis
    {
        [Key]
        [Required]
        public long id { get; set; }
        public int? analysistype { get; set; }
        public string doneby { get; set; }
        public int? analysisid { get; set; }
        public DateTime? date { get; set; }
    }
}
