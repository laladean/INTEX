using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class newsarticle
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string urltoimage { get; set; }
        public string url { get; set; }
    }
}
