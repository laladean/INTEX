using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class yarnmanipulation
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string thickness { get; set; }
        public string angle { get; set; }
        public string manipulation { get; set; }
        public string material { get; set; }
        public string count { get; set; }
        public string component { get; set; }
        public string Pply { get; set; }
        public int? yarnmanipulationid { get; set; }
        public string direction { get; set; }
    }
}
