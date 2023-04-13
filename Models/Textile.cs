using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class textile
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string locale { get; set; }
        public int? textileid { get; set; }
        public string description { get; set; }
        public string burialnumber { get; set; }
        public string estimatedperiod { get; set; }
        public DateTime? sampledate { get; set; }
        public DateTime? photographeddate { get; set; }
        public string direction { get; set; }
        
    }
}
