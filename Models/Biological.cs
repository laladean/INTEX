using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class biological
    {
        [Key]
        [Required]
        public long id { get; set; }
        public int? racknumber { get; set; }
        public int? bagnumber { get; set; }
        public string previouslysampled { get; set; }
        public string initials { get; set; }
        public int? clusternumber { get; set; }
        public DateTime? date { get; set; }
        public string notes { get; set; }
    }
}
