using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class photoform
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string area { get; set; }
        public string squarenorthsouth { get; set; }
        public string tableassociation { get; set; }
        public string filename { get; set; }
        public string photographer { get; set; }
        public string burialnumber { get; set; }
        public string squareeastwest { get; set; }
        public string eastwest { get; set; }
        public string northsouth { get; set; }
        public DateTime? photodate { get; set; }
    }
}
