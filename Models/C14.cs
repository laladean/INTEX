using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class c14
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int? size { get; set; }
        public int? agebp { get; set; }
        public int? calibratedspan { get; set; }
        public int? tubenumber { get; set; }
        public int? calibrateddatemin { get; set; }
        public int? calibrateddateavg { get; set; }
        public string foci { get; set; }
        public int? rack { get; set; }
        public int? calendardate { get; set; }
        public int? calibrateddatemax { get; set; }
        public string c14lab { get; set; }
        public string questions { get; set; }
        public string location { get; set; }
    }
}
